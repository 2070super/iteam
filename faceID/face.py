import cv2
import numpy as np
import shutil
import os
def face():
    na=input("请输入姓名：")
    imagepath='face//'+ na
    if os.path.isdir(imagepath):
        shutil.rmtree(imagepath)
        os.mkdir(imagepath)
    else:
        os.mkdir(imagepath)
    cap=cv2.VideoCapture(0)
    kernel=np.ones((5,5),np.uint8)
    num=0
    while(True):
        hx,frame=cap.read()
        if hx is False:
            print("error,no find input sign,check your camera or file"
              "")
            exit()
        img=frame.copy()
        frame=cv2.cvtColor(frame ,cv2.COLOR_BGR2GRAY)
        facedata=cv2.CascadeClassifier('./face.xml')
        faceRect=facedata.detectMultiScale(frame,scaleFactor=1.1,minNeighbors=7)
        for (x,y,w,h) in faceRect:
            if(num>1000):
                break;
            name = '%s/%d.jpg' % ('.//face//' + na, num)
            cv2.rectangle(img,(x,y),(x+w,y+h),(0,255,0))
            image=frame[y-10:y+h+10,x-10:x+w+10]
            print("save image:",num,",total 1000")
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
if __name__ is "__main__":
    face()