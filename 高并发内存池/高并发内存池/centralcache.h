#pragma once
#include"common.h"

//����ģʽ
class centralcache
{
public:
	centralcache* getinstance();
private:
	spanlist _spanlist[NFREELISTS];
	static centralcache _sinst;
	centralcache()//��ʼ��
	{}
	centralcache(const centralcache&) = delete;//ʹ�����޷����ÿ������캯����

};