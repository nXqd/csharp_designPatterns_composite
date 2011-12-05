using CS_binaryTree_CompositePattern.helper;

namespace CS_binaryTree_CompositePattern.core {

    /// <summary>
    /// Abstract Component for Composite Pattern
    /// </summary>
    public abstract class AbsBinary {
        public abstract void Add(TreeNode node);
    }

    /// <summary>
    /// BinaryTree : just a TreeNode presented as root
    /// </summary>
    public class BinaryTree : AbsBinary {

        private static int _total = 0;

        #region constructors
        public BinaryTree(TreeNode treeNode) {
            Root = treeNode;
        }

        public BinaryTree() {
        }
        #endregion

        public TreeNode Root { get; set; }

        public override void Add(TreeNode node) {
            Root.Add(node);
        }

        public int GetSmallestPrime(TreeNode node) {
            int smallest = -1;
            if (node.Left != null && node.Left.Value != -1) {
                smallest = GetSmallestPrime(node.Left);
            }
            if (smallest != -1)
                return smallest;

            if (NxqdMath.IsPrime(node.Value)) {
                return node.Value;
            }

            if (node.Right != null && node.Right.Value != -1)
                return GetSmallestPrime(node.Right);

            TreeNode nodeTmp = node.Parent;
            node.Value = -1;
            GetSmallestPrime(nodeTmp);

            return -1;
        }
        public int GetTotal(TreeNode node) {
            _total += Root.Value;
            _GetTotal(node);
            return _total;
        }

        private void _GetTotal(TreeNode node) {
            if (node.Left != null && node.Left.Value != -1)
                _GetTotal(node.Left);
            if (node.Right != null && node.Right.Value != -1)
                _GetTotal(node.Right);

            _total += node.Value;
            node.Value = -1;
        }

    }

    /// <summary>
    /// Represent 
    /// </summary>
    public class TreeNode : AbsBinary {
        #region constructors
        public TreeNode(int value) {
            Value = value;
        }

        public TreeNode() {
        }
        #endregion

        public int Value { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Parent { get; set; }

        public override void Add(TreeNode node) {
            if (node.Value >= Value) {
                if (Right == null) {
                    Right = node;
                    Right.Parent = this;
                }
                else
                    Right.Add(node);
            }

            if (node.Value < Value) {
                if (Left == null) {
                    Left = node;
                    Left.Parent = this;
                }
                else
                    Left.Add(node);
            }
        }
    }
}