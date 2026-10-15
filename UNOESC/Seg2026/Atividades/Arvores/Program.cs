using Arvores;

Console.WriteLine("Agora com Arvores");

TreeNode<int> root = new TreeNode<int>();
root.Data = 100;
Tree<int> tree = new Tree<int>(); 
//tree.Root = root;

// Filhos da raiz: 50, 1, 150
tree.Root.Children = new List<TreeNode<int>> {
    new TreeNode<int> {Data = 50,  Parent = tree.Root},
    new TreeNode<int> {Data = 1,   Parent = tree.Root},
    new TreeNode<int> {Data = 150, Parent = tree.Root}
};

// Filho do 50: 12
tree.Root.Children[0].Children = new List<TreeNode<int>> {
    new TreeNode<int> {Data = 12, Parent = tree.Root.Children[0]}
};

// Filhos do 12: 45 e 21
tree.Root.Children[0].Children[0].Children = new List<TreeNode<int>> {
    new TreeNode<int> {Data = 45, Parent = tree.Root.Children[0].Children[0]},
    new TreeNode<int> {Data = 21, Parent = tree.Root.Children[0].Children[0]}
};

// Filho do 21: 6
tree.Root.Children[0].Children[0].Children[1].Children = new List<TreeNode<int>> {
    new TreeNode<int> {Data = 6, Parent = tree.Root.Children[0].Children[0].Children[1]}
};

// Filhos do 1: 70 e 61
tree.Root.Children[1].Children = new List<TreeNode<int>> {
    new TreeNode<int> {Data = 70, Parent = tree.Root.Children[1]},
    new TreeNode<int> {Data = 61, Parent = tree.Root.Children[1]}
};

// Filhos do 150: 30, 5 e 11
tree.Root.Children[2].Children = new List<TreeNode<int>> {
    new TreeNode<int> {Data = 30, Parent = tree.Root.Children[2]},
    new TreeNode<int> {Data = 5,  Parent = tree.Root.Children[2]},
    new TreeNode<int> {Data = 11, Parent = tree.Root.Children[2]}
};

// Filhos do 30: 96 e 9
tree.Root.Children[2].Children[0].Children = new List<TreeNode<int>> {
    new TreeNode<int> {Data = 96, Parent = tree.Root.Children[2].Children[0]},
    new TreeNode<int> {Data = 9,  Parent = tree.Root.Children[2].Children[0]}
};