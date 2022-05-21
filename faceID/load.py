import cv2
import tensorflow as tf
import pickle
if __name__ == '__main__':
    model= tf.keras.models.load_model("./output/simple_nn.model")
    lb = pickle.loads(open('./output/simple_nn_lb.pickle', "rb").read())
    # 框住人脸的矩形边框颜色
    color = (0, 255, 0)

    # 捕获指定摄像头的实时视频流
    camera = cv2.VideoCapture(0)

    # 人脸识别分类器本地存储路径
    cascade_path = "./face.xml"

    # 循环检测识别人脸
    while True:
        ret, frame = camera.read()  # 读取一帧视频
        if ret is False:
            print("error,no find input sign,check your camera or file")
            exit()
        # 图像灰化，降低计算复杂度
        gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)

        # 使用人脸识别分类器，读入分类器
        cascade = cv2.CascadeClassifier(cascade_path)

        # 利用分类器识别出哪个区域为人脸
        faces = cascade.detectMultiScale(gray,scaleFactor=1.1,minNeighbors=7)
        if len(faces) > 0:
            for (x, y, w, h) in faces:
                # 截取脸部图像提交给模型识别这是谁
                image = frame[y: y + h, x: x + w]
                image = cv2.resize(image, (32, 32))

                # scale图像数据
                image = image.astype("float") / 255.0

                # 对图像进行拉平操作
                image = image.flatten()
                image = image.reshape((1, image.shape[0]))
                faceID=model.predict(image)
                i = faceID.argmax(axis=1)[0]
                label = lb.classes_[i]
                cv2.putText(frame, label, (x, y - 20), cv2.FONT_HERSHEY_SIMPLEX, 1, 255, 2)  #显示名字
                frame = cv2.rectangle(frame, (x, y), (x + w, y + h), (255, 0, 0), 2)
        cv2.imshow("camera", frame)

        # 等待1毫秒看是否有按键输入
        k = cv2.waitKey(1)
        # 如果输入q则退出循环
        if k & 0xFF == ord('q'):
            break

    # 释放摄像头并销毁所有窗口
    camera.release()
    cv2.destroyAllWindows()
