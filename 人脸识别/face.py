import cv2
import numpy as np
import os
na=input("请输入姓名：")
os.mkdir(r'C://Users//admin//Desktop//face//'+ na )
src_data_folder = 'C://Users//admin//Desktop//face'  # todo 修改你的原始数据集路径
target_data_folder = 'C://Users//admin//Desktop//new_face//'  # todo 修改为你要存放的路径

cap=cv2.VideoCapture(0)
kernel=np.ones((5,5),np.uint8)
num=0
while(True):
    hx,frame=cap.read()
    if hx is False:
        print("error")
        exit()
    img=frame.copy()
    frame=cv2.cvtColor(frame ,cv2.COLOR_BGR2GRAY)
    facedata=cv2.CascadeClassifier('C://Users//admin//PycharmProjects//parting//venv//face.xml')
    faceRect=facedata.detectMultiScale(frame,scaleFactor=1.1,minNeighbors=7)
    for (x,y,w,h) in faceRect:
        name = '%s/%d.jpg' % ('C://Users//admin//Desktop//face//'+ na, num)
        if(num>1000):
            break;

        cv2.rectangle(img,(x,y),(x+w,y+h),(0,255,0))
        image=frame[y-10:y+h+10,x-10:x+w+10]
        cv2.imwrite(name,image)
        num+=1

    cv2.namedWindow("videos",cv2.WINDOW_AUTOSIZE)
    cv2.imshow('videos',img)
    if cv2.waitKey(1) & 0xFF==ord('q'):
        break
    if num>1000:
        print("succeed")
        break;
cap.release()
import os
import random
from shutil import copy2
test_scale = 0.2
val_scale=0.2
train_scale=0.6
print("开始数据集划分")
class_names = os.listdir(src_data_folder)
# 在目标目录下创建文件夹
split_names = ['train', 'val', 'test']
for split_name in split_names:
    split_path = os.path.join(target_data_folder, split_name).replace('\\','//')
    if os.path.isdir(split_path):
        pass
    else:
        os.mkdir(split_path)
        # 然后在split_path的目录下创建类别文件夹
    for class_name in class_names:
        class_split_path = os.path.join(split_path, class_name).replace('\\','//')
        if os.path.isdir(class_split_path):
            pass
        else:
            os.mkdir(class_split_path)

    # 按照比例划分数据集，并进行数据图片的复制
    # 首先进行分类遍历
for class_name in class_names:
        current_class_data_path = os.path.join(src_data_folder, class_name).replace('\\','//')
        current_all_data = os.listdir(current_class_data_path)
        current_data_length = len(current_all_data)
        current_data_index_list = list(range(current_data_length))
        random.shuffle(current_data_index_list)

        train_folder = os.path.join(os.path.join(target_data_folder, 'train'), class_name).replace('\\','//')
        val_folder = os.path.join(os.path.join(target_data_folder, 'val'), class_name).replace('\\','//')
        test_folder = os.path.join(os.path.join(target_data_folder, 'test'), class_name).replace('\\','//')
        train_stop_flag = current_data_length * train_scale
        val_stop_flag = current_data_length * (train_scale + val_scale)
        current_idx = 0
        train_num = 0
        val_num = 0
        test_num = 0
for i in current_data_index_list:
            src_img_path = os.path.join(current_class_data_path, current_all_data[i]).replace('\\','//')
            if current_idx <= train_stop_flag:
                copy2(src_img_path, train_folder)
                # print("{}复制到了{}".format(src_img_path, train_folder))
                train_num = train_num + 1
            elif (current_idx > train_stop_flag) and (current_idx <= val_stop_flag):
                copy2(src_img_path, val_folder)
                # print("{}复制到了{}".format(src_img_path, val_folder))
                val_num = val_num + 1
            else:
                copy2(src_img_path, test_folder)
                # print("{}复制到了{}".format(src_img_path, test_folder))
                test_num = test_num + 1

            current_idx = current_idx + 1

print("*********************************{}*************************************".format(class_name))
print(
            "{}类按照{}：{}：{}的比例划分完成，一共{}张图片".format(class_name, train_scale, val_scale, test_scale, current_data_length))
print("训练集{}：{}张".format(train_folder, train_num))
print("验证集{}：{}张".format(val_folder, val_num))
print("测试集{}：{}张".format(test_folder, test_num))











