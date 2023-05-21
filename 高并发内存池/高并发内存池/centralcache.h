#pragma once
#include"common.h"

//单例模式
class centralcache
{
public:
	static centralcache* getinstance();
	// 从中心缓存是否有这么多给线程缓存
	size_t FetchRangeObj(void*& start, void*& end, size_t n, size_t byte_size);
private:
	spanlist _spanlist[NFREELISTS];
	static centralcache _sinst;
	centralcache()//初始化
	{}
	centralcache(const centralcache&) = delete;//使别人无法调用拷贝构造函数。

};