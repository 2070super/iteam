import pandas as pd
import numpy as np
from sklearn.model_selection import train_test_split
import matplotlib.pyplot as plt
import warnings
warnings.filterwarnings('ignore')
plt.style.use({'figure.figsize':(25,20)})
housingdata=pd.read_csv("./data/train.csv")
X=housingdata.drop(["MEDV"],axis=1)
Y=housingdata["MEDV"]
x_train,x_test,y_train,y_test=train_test_split(X,Y,random_state=0)#建立数据集和测试集
from sklearn.ensemble import RandomForestRegressor
from sklearn.model_selection import  GridSearchCV
param={
    'n_estimators':[5,10,20,50,100,200],#决策树个数
    'max_depth':[3,5,7],#最大深度
    'max_features':[0.6,0.7,0.8,1]#最大特征数
}
rf=RandomForestRegressor()
grid=GridSearchCV(rf,param_grid=param,cv=3)
grid.fit(x_train,y_train)
print(grid.best_params_)#查看训练出来的参数
rf_reg=grid.best_estimator_#使用最佳参数
print(rf_reg)
#随机打印一个决策树图像
from sklearn.tree import export_graphviz
estimator=rf_reg.estimators_[3]
export_graphviz(estimator,out_file='./data/tree.dot')

#特征重要度分析
print("特征排序：")
feature_names=X.columns
feature_importance=rf_reg.feature_importances_
indices=np.argsort(feature_importance)[::-1]
for index in indices:
    print("feature %s (%f)"%(feature_names[index],feature_importance[index]))
#画出重要特征图像
plt.figure(figsize=(16,8))
plt.title("Importance of different characteristics of random forest model")
plt.bar(range(len(feature_importance)),feature_importance[indices],color='b')
plt.xticks(range(len(feature_importance)),np.array(feature_names)[indices],color='b')
plt.show()
#进行预测
result={"label":y_test,"prediction":rf_reg.predict(x_test)}
result=pd.DataFrame(result)
#画出测试集以及预测的关系
result["label"].plot(style='k.',figsize=(15,5))
result["prediction"].plot(style='r.')
plt.legend(fontsize=15,markerscale=3)
plt.tick_params(labelsize=25)
plt.grid()
plt.show()
#计算均方误差
from sklearn import metrics
mse=metrics.mean_absolute_error(Y,rf_reg.predict(X))
print("均方误差为：",mse)
#存储结果
sub={"prediction":rf_reg.predict(x_test)}
sub=pd.DataFrame(sub)
sub.to_csv('结果.csv')