import cv2
import os


def getTrainingData(window_name, camera_id, path_name, max_num):  # path_name是图片存储目录，max_num是需要捕捉的图片数量
    cv2.namedWindow(window_name)  # 创建窗口
    cap = cv2.VideoCapture(camera_id)  # 打开摄像头
    classifier = cv2.CascadeClassifier('cv2_data/haarcascade_frontalface_alt.xml')  # 加载分类器,Openvc自带的分类器
    color = (0, 255, 0)  # 人脸矩形框的颜色,绿色
    num = 0  # 记录存储的图片数量

    while cap.isOpened():
        ok, frame = cap.read()
        if not ok:
            print("no sign input ,please check your camera")
            break

        gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)  # 灰度化
        faceRects = classifier.detectMultiScale(gray, scaleFactor=1.2, minNeighbors=3, minSize=(32, 32))

        if len(faceRects) > 0:
            for faceRect in faceRects:
                x, y, w, h = faceRect
                # 捕捉到的图片的名字，这里用到了格式化字符串的输出
                image_name = '%s%d.jpg' % (path_name, num)
                image = frame[y:y + h, x:x + w]  # 将当前帧含人脸部分保存为图片，这里访问的是从y位开始到y+h-1位
                cv2.imwrite(image_name, image)

                num += 1
                # 超过指定最大保存数量则退出循环
                if num > max_num:
                    break

                cv2.rectangle(frame, (x, y), (x + w, y + h), color, 2)  # 画出矩形框
                font = cv2.FONT_HERSHEY_SIMPLEX  # 获取内置字体
                cv2.putText(frame, ('%d' % num), (x + 30, y + 30), font, 1, (255, 0, 255),
                            4)  # 调用函数，对人脸坐标位置，添加一个(x+30,y+30）的矩形框用于显示当前捕捉到了多少人脸图片
        if num > max_num:
            break
        cv2.imshow(window_name, frame)
        c = cv2.waitKey(10)
        if c == 27:  # q 退出捕获
            break

    cap.release()  # 释放摄像头并销毁所有窗口
    cv2.destroyAllWindows()
    print('Finished.')


# 主函数
def read(n):
    na=n
    faceDataPath = 'faceData/'+na  # 人脸数据路径,需要提前创建好对应的文件夹
    max_num = 100  # 最多捕获的人脸数量
    faceDataPath_absPath = os.path.abspath(os.path.join(os.getcwd(), faceDataPath))  # 绝对路径
    print('正在捕获人脸,写入', faceDataPath_absPath, '文件夹中')  # 捕获人脸图片
    if not os.path.exists(os.path.join(os.getcwd(), faceDataPath)):  # 是否存在存放脸部数据的文件夹
        os.mkdir(os.path.join(os.getcwd(), faceDataPath))  # 不存在,则创建

    getTrainingData('getTrainData', 0, faceDataPath, max_num)  # 注意这里的training_data_xx 文件夹就在程序工作目录下
