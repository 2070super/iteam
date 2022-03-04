from selenium import webdriver
from bs4 import BeautifulSoup
import pandas as pd
import time
from pyecharts import Bar,Line,Overlap
import numpy as np

def getHtml(url):
    brower=webdriver.Chrome()
    brower.get(url)
    brower.maximize_window()
    htmlcode=brower.page_source
    brower.implicitly_wait(10)
    time.sleep(3)
    return htmlcode
def parsehtml(code,result,key):
    soup=BeautifulSoup(code,'lxml')
    lis=soup.select("#J_goodsList>ul>li")
    print(len(lis))
    for li in lis:
        price = li.select("div.p-price > strong > i")[0].get_text()
        comment = li.select("div.p-commit > strong")[0].get_text()
        brand = li.select("div.p-shop > span > a")[0].get_text()
        href = li.select("div.p-img > a")[0]["href"]
        http = "https:" + href

        hrefcode = getHtml(http)
        bsp = BeautifulSoup(hrefcode, 'lxml')
        goods = bsp.select("div.crumb-wrap > div.w > div.crumb.fl.clearfix > div.ellipsis")[0].get_text()
        img = bsp.select("div.preview > div.jqzoom.main-img >img#spec-img")[0]["src"]
        imgsrc = "https:" + img
        print(goods)
        print(imgsrc)
        result = result.append(pd.DataFrame(
        {'商品': [goods], '评论': [comment], '价格': [price], '品牌': [brand], '链接': [href], '图片': [imgsrc]}),
        ignore_index=True)
        result.to_csv("data/" + key + ".csv", index=False, sep=',', encoding="utf_8_sig")
def pic(key):
    df2 = pd.read_csv("data/"+key+".csv",usecols=[0])

    good =np.array(df2)
    df = pd.read_csv("data/" + key + ".csv", usecols=[2])
    price=np.array(df)

    goods = [x[0] for x in list(good)]
    prices = [x[0] for x in list(price)]
    print(goods)
    print(prices)

    print()
    m=Bar()
    line=Line()
    line.add("价格",goods,prices)
    m.add("价格", goods, prices,
        is_stack=False,
        bar_category_gap='20%')
    overlap=Overlap()
    overlap.add(m)
    overlap.add(line)
    overlap.render()
if __name__=="__main__":
    key=input("请输入查询关键词：")
    result = pd.DataFrame(columns=( '商品','评论', '价格','品牌','链接','图片'))
    url="https://search.jd.com/Search?keyword="+key+"&enc=utf-8&click=1"
    s=getHtml(url)
    parsehtml(s,result,key)
    pic(key)