/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public List<int> PostorderTraversal(TreeNode root) {
        List<int> values = new List<int>();
        InOrder(root);
        return values;
        void InOrder(TreeNode root) {
            if (root is null) return;
            InOrder(root.left);
            InOrder(root.right);
            values.Add(root.val);
        }
    }
}