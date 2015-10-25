using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

namespace VipSoft
{
    static class Function
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }


        /// <summary>
        /// 绑定产品分类到下拉菜单
        /// </summary>
        public static void BindGoodsClass(ComboBox dropList, DataTable dtClass)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Key");
            dt.Columns.Add("Value");
            DataRow newRow = dt.NewRow();
            newRow["Key"] = "所有分类";
            newRow["Value"] = "0";
            dt.Rows.Add(newRow);
            int index = 0;
            CreateGoodsClassItem(ref dt, ref index, dtClass, "0");
            dropList.DataSource = dt;
            dropList.DisplayMember = "Key";
            dropList.ValueMember = "Value";
        }

        /// <summary>
        /// 递归创建下拉菜单的项目
        /// </summary>
        private static void CreateGoodsClassItem(ref DataTable dt, ref int index, DataTable dtData, string pid)
        {
            if (pid != "0")
                index++;
            DataRow[] drs = dtData.Select("parentID=" + pid);
            foreach (DataRow dr in drs)
            {
                string blank = "";
                for (int i = 0; i < index; i++)
                    blank += "--";

                DataRow newRow = dt.NewRow();
                newRow["Key"] = blank + dr["ClassName"].ToString();
                newRow["Value"] = dr["ID"].ToString();
                dt.Rows.Add(newRow);
                string str = dr["ID"].ToString();
                CreateGoodsClassItem(ref dt, ref index, dtData, str);
                index--;
            }
        }

        /// <summary>
        /// 绑定产品分类到树
        /// </summary>
        public static void BindGoodsClass(TreeView tree, DataTable dtClass)
        {
            TreeNode rootNode = new TreeNode();
            rootNode.Text = "全部产品";
            rootNode.Name = "class_0";
            CreateGoodsClassItem(ref rootNode, dtClass, "0");
            tree.Nodes.Add(rootNode);
            tree.ExpandAll();
        }

        /// <summary>
        /// 递归创建树的节点
        /// </summary>
        private static void CreateGoodsClassItem(ref TreeNode node, DataTable dtClass, string parentID)
        {
            DataRow[] drs = dtClass.Select("parentID=" + parentID);
            foreach (DataRow dr in drs)
            {
                TreeNode n = new TreeNode();
                n.Text = dr["ClassName"].ToString();
                n.Name = "class_" + dr["ID"].ToString();
                CreateGoodsClassItem(ref n, dtClass, dr["ID"].ToString());
                node.Nodes.Add(n);
            }
        }

        /// <summary>
        /// 检查某一个分类是否是最底层类别
        /// </summary>
        public static bool CheckIsLowestClass(DataTable dtClass, string classID)
        {
            DataRow[] drs = dtClass.Select("parentID=" + classID);
            return drs.Length == 0;
        }

        /// <summary>
        /// 取得某一个分类的子类别的ID列表
        /// </summary>
        public static string GetChildClassListStr(DataTable dtClass, string parentID)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            foreach (DataRow row in dtClass.Rows)
            {
                if (row["ParentID"].ToString() == parentID)
                {
                    if (sb.ToString() != "")
                        sb.Append(",");
                    sb.Append(row["ID"].ToString());
                }
            }
            return sb.ToString();
        }
    }

    #region PublicState 类：保存各种全局状态，如登录状态，全局变量等
    public class PublicState
    {
        private static VipSoft.Model.Master _master;
        /// <summary>
        /// 当前的操作员
        /// </summary>
        public static VipSoft.Model.Master Master
        {
            get { return _master; }
            set { _master = value; }
        }
    }
    #endregion

    #region 检测商品分类及其子类是否含有商品
    /// <summary>
    /// 检测商品分类及其子类是否含有商品
    /// </summary>
    public class CheckHasGoods
    {
        private string strID = "";
        private string[] strArray;
        private int key = 0;
        public CheckHasGoods()
        {
            strArray = new string[] { "" };
            strID = "";
            key = 0;
        }

        public int Exist(DataTable dtClass, string id)
        {
            if (new VipSoft.BLL.GoodsClass().ExistGoods(int.Parse(id)))
                key++;
            else
            {
                if (!Function.CheckIsLowestClass(dtClass, id))
                {
                    strID = Function.GetChildClassListStr(dtClass, id);
                    strArray = strID.Split(',');
                    foreach (string item in strArray)
                    {
                        Exist(dtClass, item);
                    }
                }
            }
            return key;
        }
    }
    #endregion
}
