using AppGenealogySystem.Service;
using AppGenealogySystem.UC;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.DependencyInjection;
using Svg;
using System.IO.Compression;

namespace AppGenealogySystem
{
    public partial class Form1 : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IDataService _dataService;
        Dictionary<string, Type> _workspaceMap =
    new Dictionary<string, Type>()
{
        {"Genealogy Query",typeof(UcGenealogyQuery)},
        {"Supplier",typeof(SupplierControl) },
        {"Work Order",typeof(UCWorkOrder) },
        {"BOM",typeof(UCBomList) },
        {"Production",typeof(UcProductionEx) },
        {"Receive",typeof(UcLotReceiving) },
        {"Trace Forward",typeof( UcTraceForward) },
        { "Product",typeof( UCProductList) }
};
        public Form1(IServiceProvider serviceProvider, IDataService dataService)
        {
            InitializeComponent();
            LoadTreeData();
            _serviceProvider = serviceProvider;
            _dataService = dataService;
            _dataService.WarmUp();
        }

        private void LoadTreeData()
        {
            treeView1.BackColor = Color.FromArgb(32, 34, 37);
            treeView1.ForeColor = Color.WhiteSmoke;
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(16, 16);
            SvgDocument svgFolder = SvgDocument.Open(@"Images\product.svg");
            Bitmap bmpProduct = svgFolder.Draw(16, 16);
            SvgDocument svgData = SvgDocument.Open(@"Images\data.svg");
            Bitmap bmpData = svgData.Draw(16, 16);
            // Node cha
            TreeNode rootNodeMaster = new TreeNode("Master Data");
            rootNodeMaster.ImageIndex = 0;
            rootNodeMaster.SelectedImageIndex = 0;
            SvgDocument svgFile = SvgDocument.Open(@"Images\bill.svg");
            Bitmap bmpBill = svgFile.Draw(16, 16);
            imgList.Images.Add(bmpData); // index 0
            imgList.Images.Add(bmpProduct); // index 1
            imgList.Images.Add(bmpBill);   // index 2
            treeView1.ImageList = imgList;

            TreeNode productNode = new TreeNode("Product");
            productNode.ImageIndex = 1;               // icon file
            productNode.SelectedImageIndex = 1;

            TreeNode bomNode = new TreeNode("BOM");
            bomNode.ImageIndex = 2;
            bomNode.SelectedImageIndex = 2;
            TreeNode supplierNode = new TreeNode("Supplier");
            TreeNode genealogyQuery = new TreeNode("Genealogy Query");
            // Node con 1
            TreeNode nodeOperation = new TreeNode("Operation");
            // Thêm node con vào node cha
            rootNodeMaster.Nodes.Add(productNode);
            rootNodeMaster.Nodes.Add(bomNode);
            rootNodeMaster.Nodes.Add(supplierNode);
            TreeNode workOrder = new TreeNode("Work Order");
            rootNodeMaster.Nodes.Add(workOrder);
            TreeNode receiveNode = new TreeNode("Receive");
            TreeNode productionNode = new TreeNode("Production");
            // Node con 2
            TreeNode reportNode = new TreeNode("Report & Analytics");
            nodeOperation.Nodes.Add(genealogyQuery);
            nodeOperation.Nodes.Add(receiveNode);
            nodeOperation.Nodes.Add(productionNode);
            TreeNode traceForwardNode = new TreeNode("Trace Forward");
            reportNode.Nodes.Add(traceForwardNode);


            // Thêm node cha vào TreeView
            treeView1.Nodes.Add(rootNodeMaster);
            treeView1.Nodes.Add(nodeOperation);
            treeView1.Nodes.Add(reportNode);

            // Mở rộng toàn bộ cây
            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Nodes.Count > 0) return;

            if (_workspaceMap.TryGetValue(e.Node.Text, out var factory))
            {
                LoadWorkspace(e.Node.Text);
            }
        }
        private void LoadWorkspace(string key)
        {
            var ucType = _workspaceMap[key];

            // Dùng IServiceProvider để lấy UserControl theo Type
            // Lúc này DI sẽ tự động truyền mọi tham số vào Constructor của UC đó
            var uc = (UserControl)_serviceProvider.GetRequiredService(ucType);

            //// Thêm vào giao diện
            panelWorkspace.Controls.Clear();
            //uc.Dock = DockStyle.Fill;
            panelWorkspace.Controls.Add(uc);
        }

        private void treeView1_BeforeCheck(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                e.Cancel = true;
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Nếu là parent (có node con)
            if (e.Node.Nodes.Count > 0)
            {
                treeView1.SelectedNode = null;   // bỏ chọn
                e.Node.Toggle();                 // vẫn cho expand/collapse
            }
        }
    }
}
