from sklearn.datasets import load_boston
from sklearn.model_selection import train_test_split
import pandas as pd
from sklearn.linear_model import LinearRegression
boston=load_boston()
X=boston.data
y=boston.target
put=pd.DataFrame(y)
put.to_csv('./data/房价.csv')#输出房价集
put=pd.DataFrame(X)
put.to_csv('./data/特征.csv')#输出特征集
x_train,x_test,y_train,y_test=train_test_split(X,y,test_size=0.2,random_state=888)#将数据分为训练集和测试集
lin=LinearRegression()
lin.fit(x_train,y_train)#利用训练集进行拟合
lin.score(x_test,y_test)#利用测试集进行评估
import matplotlib.pyplot as plt
c=plt.plot(lin.coef_)
plt.show()#每一列数据的斜率
lin.predict(x_test)#对房价进行预测
dev=lin.predict(x_test)-y_test
#画出测试集以及预测的关系
result={"label":y_test,"prediction":lin.predict(x_test)}
result=pd.DataFrame(result)
result["label"].plot(style='b.',figsize=(15,5))
result["prediction"].plot(style='r.')
plt.legend(fontsize=15,markerscale=3)
plt.tick_params(labelsize=25)
plt.grid()
plt.show()
import numpy as np
rmse=np.sum(np.sqrt(dev*dev))/102 #算出均方根误差
result={'prediction':lin.predict(x_test)}
result=pd.DataFrame(result)
result.to_csv('./data/结果.csv')