#pragma once
#include"common.h"

//����ģʽ
class centralcache
{
public:
	static centralcache* getinstance();
	// �����Ļ����Ƿ�����ô����̻߳���
	size_t FetchRangeObj(void*& start, void*& end, size_t n, size_t byte_size);
private:
	spanlist _spanlist[NFREELISTS];
	static centralcache _sinst;
	centralcache()//��ʼ��
	{}
	centralcache(const centralcache&) = delete;//ʹ�����޷����ÿ������캯����

};