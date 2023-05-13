#pragma once
#include"common.h"

//单例模式
class centralcache
{
public:
	centralcache* getinstance();
private:
	spanlist _spanlist[NFREELISTS];
	static centralcache _sinst;
	centralcache()//初始化
	{}
	centralcache(const centralcache&) = delete;//使别人无法调用拷贝构造函数。

};