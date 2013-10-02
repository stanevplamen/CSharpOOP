using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class AATree<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, ICloneable where TKey : IComparable<TKey>
    {
        private class TreeNode
        {
            #region Fields
            // node internal data
            internal int level;
            internal TreeNode left;
            internal TreeNode right;

            // user data
            internal TKey key;
            internal TValue value;

            #endregion Fields

            #region Properties

            public TKey Key
            {
                get
                {
                    return this.key;
                }
                set
                {
                    this.key = value;
                }
            }

            public TValue Value
            {
                get
                {
                    return this.value;
                }
                set
                {
                    this.value = value;
                }
            }

            #endregion Properties

            #region Constructors
            // constuctor for the leafSentinel node
            internal TreeNode()
            {
                this.level = 0;
                this.left = this;
                this.right = this;
            }

            // constuctor for regular nodes (that all start life as leaf nodes)
            internal TreeNode(TKey key, TValue value, TreeNode leafSentinel)
            {
                this.level = 1;
                this.left = leafSentinel;
                this.right = leafSentinel;
                this.key = key;
                this.value = value;
            }

            #endregion Constructors
        }

        #region Fields

        private TreeNode root;
        private TreeNode leafSentinel;
        private TreeNode deleted;
        private int allNodes;
        private StringBuilder sb = new StringBuilder();

        #endregion Fields   

        #region Constructors

        public AATree()
        {
            root = leafSentinel = new TreeNode();
            deleted = null;
        }

        #endregion Constructors

        #region All Methods

        #region Balancing the tree

        private void Skew(ref TreeNode node)
        {
            if (node.level == node.left.level)
            {
                // rotate right
                TreeNode left = node.left;
                node.left = left.right;
                left.right = node;
                node = left;
            }
        }

        private void Split(ref TreeNode node)
        {
            if (node.right.right.level == node.level)
            {
                // rotate left
                TreeNode right = node.right;
                node.right = right.left;
                right.left = node;
                node = right;
                node.level++;
            }
        }

        #endregion Balancing the tree

        #region Insert Delete Search Indexer

        private bool Insert(ref TreeNode node, TKey key, TValue value)
        {
            if (node == leafSentinel)
            {
                node = new TreeNode(key, value, leafSentinel);
                allNodes++;
                return true;
            }

            int resultOfCompare = key.CompareTo(node.key);
            if (resultOfCompare < 0)
            {
                if (!Insert(ref node.left, key, value))
                {
                    return false;
                }
            }
            else if (resultOfCompare > 0)
            {
                if (!Insert(ref node.right, key, value))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

            Skew(ref node);
            Split(ref node);

            return true;
        }

        private bool Delete(ref TreeNode node, TKey key)
        {
            if (node == leafSentinel)
            {
                allNodes--;
                return (deleted != null);
            }

            int resultOfCompare = key.CompareTo(node.key);
            if (resultOfCompare < 0)
            {
                if (!Delete(ref node.left, key))
                {
                    return false;
                }
            }
            else
            {
                if (resultOfCompare == 0)
                {
                    deleted = node;
                }
                if (!Delete(ref node.right, key))
                {
                    return false;
                }
            }

            if (deleted != null)
            {
                deleted.key = node.key;
                deleted.value = node.value;
                deleted = null;
                node = node.right;
            }
            else if (node.left.level < node.level - 1 || node.right.level < node.level - 1)
            {
                --node.level;
                if (node.right.level > node.level)
                {
                    node.right.level = node.level;
                }
                Skew(ref node);
                Skew(ref node.right);
                Skew(ref node.right.right);
                Split(ref node);
                Split(ref node.right);
            }

            return true;
        }

        private TreeNode Search(TreeNode node, TKey key)
        {
            if (node == leafSentinel)
            {
                return null;
            }

            int resultOfCompare = key.CompareTo(node.key);
            if (resultOfCompare < 0)
            {
                return Search(node.left, key);
            }
            else if (resultOfCompare > 0)
            {
                return Search(node.right, key);
            }
            else
            {
                return node;
            }
        }

        public bool Add(TKey key, TValue value)
        {
            return Insert(ref root, key, value);
        }

        public bool Remove(TKey key)
        {
            return Delete(ref root, key);
        }

        public TValue this[TKey key]
        {
            get
            {
                TreeNode node = Search(root, key);
                return node == null ? default(TValue) : node.value;
            }
            set
            {
                TreeNode node = Search(root, key);
                if (node == null)
                {
                    Add(key, value);
                }
                else
                {
                    node.value = value;
                }
            }
        }

        #endregion Insert Delete Search Indexer

        #region ToString Enumeration Equals Operators Clone

        public override string ToString()
        {
            sb.Clear();
            return AsString(root);
        }

        private string AsString(TreeNode node)
        {
            if (node != leafSentinel)
            {
                AsString(node.left);
                this.sb.AppendFormat("{0}, ", node.Key);
                AsString(node.right);
                return sb.ToString();
            }
            else
            {
                return sb.ToString();
            }
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            IList<KeyValuePair<TKey, TValue>> elems = new List<KeyValuePair<TKey, TValue>>();
            EnumBinarySearch(this.root, x => elems.Add(new KeyValuePair<TKey, TValue>(x.Key, x.Value)));

            foreach (var elem in elems)
            {
                yield return elem;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private void EnumBinarySearch(TreeNode node, Action<TreeNode> action)
        {
            if (node != leafSentinel)
            {
                EnumBinarySearch(node.left, action);
                action(node);
                EnumBinarySearch(node.right, action);
            }
        }

        public override bool Equals(object obj)
        {
            // If the cast is invalid, the result will be null
            AATree<TKey, TValue> other = obj as AATree<TKey, TValue>;

            // Check if we have valid not null BinarySearchTree<T> object
            if (other == null)
            {
                return false;
            }

            return AreEqual(this, other);
        }

        private bool AreEqual(AATree<TKey, TValue> a, AATree<TKey, TValue> b)
        {
            if (a.ToString() == b.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(AATree<TKey, TValue> a, AATree<TKey, TValue> b)
        {
            return AATree<TKey, TValue>.Equals(a, b);
        }

        public static bool operator !=(AATree<TKey, TValue> a, AATree<TKey, TValue> b)
        {
            return !(AATree<TKey, TValue>.Equals(a, b));
        }

        public override int GetHashCode()
        {
            int result = 1;

            if (this.root != null)
            {
                CalcHashCode(this.root, ref result);
            }

            return result;
        }

        private void CalcHashCode(TreeNode node, ref int hashCode)
        {
            if (node != leafSentinel)
            {
                hashCode = hashCode + node.GetHashCode();
                CalcHashCode(node.left, ref hashCode);
                CalcHashCode(node.right, ref hashCode);
            }
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public AATree<TKey, TValue> Clone()
        {
            AATree<TKey, TValue> copiedTree = new AATree<TKey, TValue>();
            Replicate(copiedTree, this.root);
            return copiedTree;
        }

        private void Replicate(AATree<TKey, TValue> copiedTree, TreeNode node)
        {
            if (node != leafSentinel)
            {
                copiedTree.Add(node.Key, node.Value);
                Replicate(copiedTree, node.left);
                Replicate(copiedTree, node.right);
            }
        }

        #endregion ToString Enumeration Equals Operators Clone

        #endregion All Methods
    }
}
