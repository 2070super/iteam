#include"pool.h"
#include<vector>
struct TreeNode
{
	int _val;
	TreeNode* _left;
	TreeNode* _right;

	TreeNode()
		:_val(0)
		, _left(nullptr)
		, _right(nullptr)
	{}
};
void TestObjectPool()
{
	/*ObjectPool<TreeNode> tnPool;
	std::vector<TreeNode*> v;
	for (size_t i = 0; i < 100; ++i)
	{
		TreeNode* node = tnPool.New();
		cout << node << endl;
		v.push_back(node);
	}

	for (auto e : v)
	{
		tnPool.Delete(e);
	}*/

	/*ObjectPool<TreeNode> tnPool;
	TreeNode* node1 = tnPool.New();
	TreeNode* node2 = tnPool.New();
	TreeNode* node3 = tnPool.New();
	TreeNode* node4 = tnPool.New();
	cout << node1 << endl;
	cout << node2 << endl;
	cout << node3 << endl;
	cout << node4 << endl;
	tnPool.Delete(node1);
	tnPool.Delete(node4);


	TreeNode* node10 = tnPool.New();
	cout << node10 << endl;

	TreeNode* node11 = tnPool.New();
	cout << node11 << endl;*/

	size_t begin1 = clock();
	std::vector<TreeNode*> v1;
	for (int i = 0; i < 100000; ++i)
	{
		v1.push_back(new TreeNode);
	}
	for (int i = 0; i < 100000; ++i)
	{
		delete v1[i];
	}
	v1.clear();

	for (int i = 0; i < 100000; ++i)
	{
		v1.push_back(new TreeNode);
	}

	for (int i = 0; i < 100000; ++i)
	{
		delete v1[i];
	}
	v1.clear();
	size_t end1 = clock();


	pool<TreeNode> tnPool;
	size_t begin2 = clock();
	std::vector<TreeNode*> v2;
	for (int i = 0; i < 100000; ++i)
	{
		v2.push_back(tnPool.New());
	}
	for (int i = 0; i < 100000; ++i)
	{
		tnPool.Delete(v2[i]);
	}
	v2.clear();

	for (int i = 0; i < 100000; ++i)
	{
		v2.push_back(tnPool.New());
	}
	for (int i = 0; i < 100000; ++i)
	{
		tnPool.Delete(v2[i]);
	}
	v2.clear();

	size_t end2 = clock();

	cout << end1 - begin1 << endl;
	cout << end2 - begin2 << endl;


	pool<char> chPool;

}
int main()
{
	TestObjectPool();
}