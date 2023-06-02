#pragma once
#include<iostream>
#include<assert.h>
#include"avltree.h"
#include<algorithm>
template<class k ,class v>
struct avltreenode
{
	avltreenode<k, v>* _left;
	avltreenode<k, v>* _right;
	avltreenode<k, v>* _parent;
	std::pair<k, v>_kv;
	int _bf;
	avltreenode(const std::pair<k,v>& kv)
		:_left(nullptr)
		,_right(nullptr)
		,_parent(nullptr)
		,_kv(kv)
		,_bf(0)
	{}
};
template<class k, class v>
struct avltree
{
	typedef avltreenode<k, v> node;
public:
	bool insert(const std::pair<k, v>& kv)
	{
		if (_root == nullptr)
		{
			_root = new node(kv);
			_root->_bf = 0;
			return true;
		}
		node* parent = nullptr;
		node* cur = _root;
		while (cur)
		{
			if (cur->_kv.first < kv.first)
			{
				parent = cur;
				cur = cur->_right;
			}
			else if (cur->_kv.first > kv.first)
			{
				parent = cur;
				cur = cur->_left;
			}
			else
			{
				return false;
			}
		}
		cur = new node(kv);
		if (parent->_kv.first < kv.first)
		{
			parent->_right = cur;
		}
		else
		{
			parent->_left = cur;
		}
		cur->_parent = parent;

		//����ƽ������
		/*���¹���
		* 1.�������ң�parent->bf++������parent->bf--
		* 2.���º�parent->bf=1����-1��˵������ǰparent����������ȣ���������ˣ���Ҫ���ϸ���
		* 3.������º�Ϊ0��˵������ǰΪ1or-1�����������һ���ߣ�parent�����߶Ȳ��䣬����Ҫ�������¡�
		* 3.���º�parent->bf==2or-2��˵������ǰ�Ѿ���1or-1����������ƽ�⣬parent������Ҫ��ת����
		*/
		while (parent) // ��ԶҪ���¸�
		{
			if (cur == parent->_right)
			{
				parent->_bf++;
			}
			else
			{
				parent->_bf--;
			}

			// �Ƿ�������£�
			if (parent->_bf == 0)  // 1 or -1  -�� 0  ����ڵ����ϰ����Ǳ�
			{
				// �߶Ȳ��䣬���½���
				break;
			}
			else if (parent->_bf == 1 || parent->_bf == -1)
				// 0  -�� 1 �� -1  ����ڵ㵼��һ�߱����
			{
				// �����ĸ߶ȱ��ˣ�������������
				cur = cur->_parent;
				parent = parent->_parent;
			}
			else if (parent->_bf == 2 || parent->_bf == -2)
				// -1 or 1  -�� 2 �� -2  ����ڵ㵼�±�����һ���ֱ����
			{
				// ������ƽ�� -- ��Ҫ��ת����
				if (parent->_bf == 2 && cur->_bf == 1) // ����
				{
					rotatel(parent);
				}
				else if (parent->_bf == -2 && cur->_bf == -1) // �ҵ���
				{
					rotater(parent);
				}
				else if (parent->_bf == -2 && cur->_bf == 1) // ����˫��
				{
					rotatelr(parent);
				}
				else if (parent->_bf == 2 && cur->_bf == -1) // ����˫��
				{
					rotaterl(parent);
				}

				break;
			}
			else
			{
				// ����֮ǰAVL�ʹ��ڲ�ƽ��������|ƽ������| >= 2�Ľڵ�
				assert(false);
			}
		}
		return true;
	}
	void rotatel(node* parent)
	{
		node* subr = parent->_right;
		node* subrl = subr->_left;
		parent->_right = subrl;
		if (subrl)
		{
			subrl->_parent = parent;
		}
		node* ppnode = parent->_parent;
		subr->_left = parent;
		parent->_parent = subr;
		if (_root == parent)
		{
			_root = subr;
			subr->_parent = nullptr;
		}
		else
		{
			if (ppnode->_left == parent)
			{
				ppnode->_left = subr;
			}
			else
			{
				ppnode->_right = subr;
			}
			subr->_parent = ppnode;
		}
		subr->_bf = parent->_bf = 0;
	}
	void rotater(node* parent)
	{
		node* subl = parent->_left;
		node* sublr = subl->_right;
		parent->_left = sublr;
		if (sublr)
		{
			sublr->_parent = parent;
		}
		node* ppnode = parent->_parent;
		subl->_right = parent;
		parent->_parent = subl;
		if (parent==_root)
		{
			_root = subl;
			subl->_parent = nullptr;
		}
		else
		{
			if (ppnode->_left == parent)
			{
				ppnode->_left = subl;
			}
			else
			{
				ppnode->_right = subl;
			}
			subl->_parent = ppnode;
		}
		subl->_bf = parent->_bf = 0;
	}
	void rotatelr(node* parent)
	{
		node* subl = parent->_left;
		node* sublr = subl->_right;
		int bf = sublr->_bf;
		rotatel(parent->_left);
		rotater(parent);
		sublr->_bf = 0;
		if (bf == 0)
		{
			parent->_bf = 0;
			subl->_bf = 0;
			sublr->_bf = 0;
		}
		else if (bf == 1)
		{
			parent->_bf = 0;
			subl->_bf = -1;
			sublr->_bf = 0;
		}
		else if (bf == -1)
		{
			parent->_bf = 1;
			subl->_bf = 0;
			sublr->_bf = 0;
		}
		else
		{
			// subLR->_bf��תǰ��������
			assert(false);
		}
	}
	void rotaterl(node* parent)
	{
		node* subr = parent->_right;
		node* subrl = subr->_left;
		int bf = subrl->_bf;
		rotater(parent->_right);
		rotatel(parent);
		if (bf == 0)
		{
			subr->_bf = 0;
			parent->_bf = 0;
			subrl->_bf = 0;
		}
		else if (bf == 1)
		{
			subr->_bf = 0;
			parent->_bf = -1;
			subrl->_bf = 0;
		}
		else if (bf == -1)
		{
			subr->_bf = 0;
			parent->_bf = 0;
			subrl->_bf = 1;
		}
		else
		{
			assert(false);
		}
	}
	void inorder()
	{
		_inorder(_root);
		std::cout << std::endl;
	}
	bool isbalance()
	{
		return _isbalance(_root);
	}
private:
	bool _isbalance(node* root)
	{
		if (root == nullptr)
		{
			return true;
		}
		int leftht = hight(root->_left);
		int righth = hight(root->_right);
		int diff = righth - leftht;
		if (diff != root->_bf)
		{
			std::cout << root->_kv.first << "ƽ�������쳣" << std::endl;
		}
		return (abs(righth - leftht) < 2) && _isbalance(root->_left) && _isbalance(root->_right);
	}
	int hight(node* root)
	{
		if (root == nullptr)
		{
			return 0;
		}
		int leftht = hight(root->_left);
		int righht = hight(root->_right);
		return std::max(leftht, righht) + 1;
	}
	node* _root=nullptr;
	void _inorder(node* root)
	{
		if (root == nullptr)
		{
			return;
		}
		_inorder(root->_left);
		std::cout << root->_kv.first << ":" << root->_kv.second << std::endl;
		_inorder(root->_right);
	}
};