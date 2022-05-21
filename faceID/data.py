import matplotlib
from tensorflow.keras import backend as K
from sklearn.model_selection import train_test_split
from sklearn.metrics import classification_report
from tensorflow.keras.models import Sequential
from tensorflow.keras.layers import Dropout
from tensorflow.keras.layers import Dense
from tensorflow.keras.optimizers import SGD
from tensorflow.keras.layers import Convolution2D, MaxPooling2D
from tensorflow.keras.layers import Dense, Dropout, Activation, Flatten
from tensorflow.keras import initializers
from tensorflow.keras import regularizers
import utils_paths # 主要用于图像路径处理操作，具体代码参考最后的附录
import matplotlib.pyplot as plt
import numpy as np
import argparse
from tensorflow.keras import utils as np_utils
import random
import pickle
import cv2
import os
IMAGE_SIZE=64
img_rows=IMAGE_SIZE
img_cols=IMAGE_SIZE

def resize_with_pad(image, height=IMAGE_SIZE, width=IMAGE_SIZE):
    def get_padding_size(image):
        h, w, _ = image.shape
        longest_edge = max(h, w)
        top, bottom, left, right = (0, 0, 0, 0)
        if h < longest_edge:
            dh = longest_edge - h
            top = dh // 2
            bottom = dh - top
        elif w < longest_edge:
            dw = longest_edge - w
            left = dw // 2
            right = dw - left
        else:
            pass
        return top, bottom, left, right

    top, bottom, left, right = get_padding_size(image)
    BLACK = [0, 0, 0]
    constant = cv2.copyMakeBorder(image, top, bottom, left, right, cv2.BORDER_CONSTANT, value=BLACK)

    resized_image = cv2.resize(constant, (height, width))

    return resized_image


images = []
labels = []


def traverse_dir(path):
    for file_or_dir in os.listdir(path):
        abs_path = os.path.abspath(os.path.join(path, file_or_dir))
        print(abs_path)
        if os.path.isdir(abs_path):  # dir
            traverse_dir(abs_path)
        else:  # file
            if file_or_dir.endswith('.jpg'):
                image = read_image(abs_path)
                images.append(image)
                labels.append(path)

    return images, labels

def read_image(file_path):
    image = cv2.imread(file_path)
    image = resize_with_pad(image, IMAGE_SIZE, IMAGE_SIZE)

    return image
def read_file(path):
    img_list = []
    label_list = []
    dir_counter = 0
    # IMG_SIZE = 128

    # 对路径下的所有子文件夹中的所有jpg文件进行读取并存入到一个list中
    for child_dir in os.listdir(path):
        child_path = os.path.join(path, child_dir)

        for dir_image in os.listdir(child_path):
            if dir_image.endswith('bmp'):
                # img = cv2.imread(os.path.join(child_path, dir_image))
                # resized_img = cv2.resize(img, (IMAGE_SIZE, IMAGE_SIZE))
                # recolored_img = cv2.cvtColor(resized_img, cv2.COLOR_BGR2GRAY)
                images = read_image(os.path.join(child_path, dir_image))
                img_list.append(images)
                label_list.append(dir_counter)

        dir_counter += 1

    # 返回的img_list转成了 np.array的格式
    img_list = np.array(img_list)
    label_list = np.array(label_list)
    return img_list, label_list, dir_counter


print("------开始读取数据------")
data = []
labels = []

# 遍历读取数据
# images, labels = extract_data('./faceData/')
images, labels, counter = read_file('ORL')
nb_classes = counter
print(nb_classes)
# print(labels)

labels = np.reshape(labels, [-1])
# numpy.reshape
X_train, X_test, y_train, y_test = train_test_split(images, labels, test_size=0.3,
                                                    random_state=random.randint(0, 100))
X_valid, X_test, y_valid, y_test = train_test_split(images, labels, test_size=0.5,
                                                    random_state=random.randint(0, 100))
if K.image_data_format() == "channels_first":
    X_train = X_train.reshape(X_train.shape[0], 3, img_rows, img_cols)
    X_valid = X_valid.reshape(X_valid.shape[0], 3, img_rows, img_cols)
    X_test = X_test.reshape(X_test.shape[0], 3, img_rows, img_cols)
    input_shape = (3, img_rows, img_cols)
else:
    X_train = X_train.reshape(X_train.shape[0], img_rows, img_cols, 3)
    X_valid = X_valid.reshape(X_valid.shape[0], img_rows, img_cols, 3)
    X_test = X_test.reshape(X_test.shape[0], img_rows, img_cols, 3)
    input_shape = (img_rows, img_cols, 3)
print('X_train shape:', X_train.shape)
print(X_train.shape[0], 'train samples')
print(X_valid.shape[0], 'valid samples')
print(X_test.shape[0], 'test samples')

# convert class vectors to binary class matrices
Y_train = np_utils.to_categorical(y_train, nb_classes)
Y_valid = np_utils.to_categorical(y_valid, nb_classes)
Y_test = np_utils.to_categorical(y_test, nb_classes)

X_train = X_train.astype('float32')
X_valid = X_valid.astype('float32')
X_test = X_test.astype('float32')
X_train /= 255
X_valid /= 255
X_test /= 255
# 构造网络模型结构：本次为3072-128-64-3
self = Sequential()
# kernel_regularizer=regularizers.l2(0.01) L2正则化项
# initializers.TruncatedNormal 初始化参数方法，截断高斯分布
#print(dataset.X_train.shape[1:])
self.add(Convolution2D(32, 3, 3, input_shape=X_train.shape[1:]))
self.add(Activation('relu'))
self.add(Convolution2D(32, 3, 3))
self.add(Activation('relu'))
self.add(MaxPooling2D(pool_size=(2, 2)))
self.add(Dropout(0.25))
self.add(Convolution2D(64, 3, 3, padding='same'))
self.add(Activation('relu'))
self.add(Convolution2D(64, 3, 3, padding='same'))
self.add(Activation('relu'))
self.add(MaxPooling2D(pool_size=(2, 2,), padding='same'))
self.add(Dropout(0.25))
self.add(Flatten())
self.add(Dense(512))
self.add(Activation('relu'))
self.add(Dropout(0.5))
self.add(Dense(nb_classes))
self.add(Activation('softmax'))

self.summary()
# 初始化参数
INIT_LR = 0.001
EPOCHS = 40000

# 模型编译
print("------准备训练网络------")
opt = SGD(lr=INIT_LR)
self.compile(loss="categorical_crossentropy", optimizer=opt,
    metrics=["accuracy"])

# 拟合模型
H = self.fit(X_train, Y_train, validation_data=(X_valid, Y_valid),
    epochs=EPOCHS, batch_size=32)
# 绘制结果曲线
N = np.arange(0, EPOCHS)
plt.style.use("ggplot")
plt.figure()
plt.plot(N[1500:], H.history["accuracy"][1500:], label="train_acc")
plt.plot(N[1500:], H.history["val_accuracy"][1500:], label="val_acc")
plt.title("Training and Validation Accuracy (Simple NN)")
plt.xlabel("Epoch #")
plt.ylabel("Accuracy")
plt.legend()
plt.savefig('./output/simple_nn_plot_acc.png')

plt.figure()
plt.plot(N, H.history["loss"], label="train_loss")
plt.plot(N, H.history["val_loss"], label="val_loss")
plt.title("Training and Validation Loss (Simple NN)")
plt.xlabel("Epoch #")
plt.ylabel("Loss")
plt.legend()
plt.savefig('./output/simple_nn_plot_loss.png')


# 保存模型到本地
print("------正在保存模型------")
self.save('./output/simple_nn.model')

