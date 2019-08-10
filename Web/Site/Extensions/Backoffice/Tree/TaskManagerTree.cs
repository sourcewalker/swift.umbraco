using System;
using System.Text;
using umbraco.businesslogic;
using umbraco.cms.presentation.Trees;

namespace Swift.Umbraco.Web.Extensions.Backoffice.Tree
{
    [Tree("tools", "taskManager", "Task Manager", "icon-shuffle", "icon-squiggly-line", sortOrder: 6)]
    public class TaskManagerTree : BaseTree
    {
        public TaskManagerTree(string application)
            : base(application)
        {
        }

        protected override void CreateRootNode(ref XmlTreeNode rootNode)
        {
            rootNode.NodeType = "taskManager";
            rootNode.NodeID = "init";
            rootNode.Action = "#";
            rootNode.Action = "javascript:openPage('/umbraco/backoffice/Plugins/hangfire');";
        }

        public override void Render(ref XmlTree tree)
        {
            if (this.NodeKey == string.Empty) // Rendering the child nodes of the jobs folder
            {
                var jobsNode = XmlTreeNode.Create(this);
                jobsNode.NodeID = "1";
                jobsNode.NodeType = string.Empty;
                jobsNode.Text = "Hangfire Jobs";
                jobsNode.Action = "#";
                jobsNode.Action = "javascript:openPage('/umbraco/backoffice/Plugins/hangfire/jobs/enqueued');";
                jobsNode.Icon = "~/App_Plugins/Tools/Hangfire/hangfire.png";
                jobsNode.HasChildren = true;
                TreeService treeService = new TreeService(-1, TreeAlias, ShowContextMenu, IsDialog, DialogMode, app, "HangfireJobs");
                jobsNode.Source = treeService.GetServiceUrl();
                OnBeforeNodeRender(ref tree, ref jobsNode, EventArgs.Empty);
                tree.Add(jobsNode);
                OnAfterNodeRender(ref tree, ref jobsNode, EventArgs.Empty);

                var retriesNode = XmlTreeNode.Create(this);
                retriesNode.NodeID = "2";
                retriesNode.NodeType = string.Empty;
                retriesNode.Text = "Hangfire retries";
                retriesNode.Action = "#";
                retriesNode.Action = "javascript:openPage('/umbraco/backoffice/Plugins/hangfire/retries');";
                retriesNode.Icon = "~/App_Plugins/Tools/Hangfire/hangfire.png";
                retriesNode.HasChildren = false;
                OnBeforeNodeRender(ref tree, ref retriesNode, EventArgs.Empty);
                tree.Add(retriesNode);
                OnAfterNodeRender(ref tree, ref retriesNode, EventArgs.Empty);

                var recurringNode = XmlTreeNode.Create(this);
                recurringNode.NodeID = "3";
                recurringNode.NodeType = string.Empty;
                recurringNode.Text = "Hangfire recurring";
                recurringNode.Action = "#";
                recurringNode.Action = "javascript:openPage('/umbraco/backoffice/Plugins/hangfire/recurring');";
                recurringNode.Icon = "~/App_Plugins/Tools/Hangfire/hangfire.png";
                recurringNode.HasChildren = false;
                OnBeforeNodeRender(ref tree, ref recurringNode, EventArgs.Empty);
                tree.Add(recurringNode);
                OnAfterNodeRender(ref tree, ref recurringNode, EventArgs.Empty);

                var serversNode = XmlTreeNode.Create(this);
                serversNode.NodeID = "4";
                serversNode.NodeType = string.Empty;
                serversNode.Text = "Hangfire servers";
                serversNode.Action = "#";
                serversNode.Action = "javascript:openPage('/umbraco/backoffice/Plugins/hangfire/servers');";
                serversNode.Icon = "~/App_Plugins/Tools/Hangfire/hangfire.png";
                serversNode.HasChildren = false;
                OnBeforeNodeRender(ref tree, ref serversNode, EventArgs.Empty);
                tree.Add(serversNode);
                OnAfterNodeRender(ref tree, ref serversNode, EventArgs.Empty);
            }
            else if (this.NodeKey == "HangfireJobs")
            {
                var enqueuedNode = XmlTreeNode.Create(this);
                enqueuedNode.NodeID = "5";
                enqueuedNode.NodeType = string.Empty;
                enqueuedNode.Text = "Enqueued Jobs";
                enqueuedNode.Action = "#";
                enqueuedNode.Action = "javascript:openPage('/umbraco/backoffice/Plugins/hangfire/jobs/enqueued');";
                enqueuedNode.Icon = "~/App_Plugins/Tools/Hangfire/hangfire.png";
                enqueuedNode.HasChildren = false;
                tree.Add(enqueuedNode);

                var sheduledNode = XmlTreeNode.Create(this);
                sheduledNode.NodeID = "5";
                sheduledNode.NodeType = string.Empty;
                sheduledNode.Text = "Scheduled Jobs";
                sheduledNode.Action = "#";
                sheduledNode.Action = "javascript:openPage('/umbraco/backoffice/Plugins/hangfire/jobs/scheduled');";
                sheduledNode.Icon = "~/App_Plugins/Tools/Hangfire/hangfire.png";
                sheduledNode.HasChildren = false;
                tree.Add(sheduledNode);

                var processingNode = XmlTreeNode.Create(this);
                processingNode.NodeID = "6";
                processingNode.NodeType = string.Empty;
                processingNode.Text = "Processing Jobs";
                processingNode.Action = "#";
                processingNode.Action = "javascript:openPage('/umbraco/backoffice/Plugins/hangfire/jobs/processing');";
                processingNode.Icon = "~/App_Plugins/Tools/Hangfire/hangfire.png";
                processingNode.HasChildren = false;
                tree.Add(processingNode);

                var succeededNode = XmlTreeNode.Create(this);
                succeededNode.NodeID = "7";
                succeededNode.NodeType = string.Empty;
                succeededNode.Text = "Succeeded Jobs";
                succeededNode.Action = "#";
                succeededNode.Action = "javascript:openPage('/umbraco/backoffice/Plugins/hangfire/jobs/succeeded');";
                succeededNode.Icon = "~/App_Plugins/Tools/Hangfire/hangfire.png";
                succeededNode.HasChildren = false;
                tree.Add(succeededNode);

                var failedNode = XmlTreeNode.Create(this);
                failedNode.NodeID = "8";
                failedNode.NodeType = string.Empty;
                failedNode.Text = "Failed Jobs";
                failedNode.Action = "#";
                failedNode.Action = "javascript:openPage('/umbraco/backoffice/Plugins/hangfire/jobs/failed');";
                failedNode.Icon = "~/App_Plugins/Tools/Hangfire/hangfire.png";
                failedNode.HasChildren = false;
                tree.Add(failedNode);

                var deletedNode = XmlTreeNode.Create(this);
                deletedNode.NodeID = "9";
                deletedNode.NodeType = string.Empty;
                deletedNode.Text = "Deleted Jobs";
                deletedNode.Action = "#";
                deletedNode.Action = "javascript:openPage('/umbraco/backoffice/Plugins/hangfire/jobs/deleted');";
                deletedNode.Icon = "~/App_Plugins/Tools/Hangfire/hangfire.png";
                deletedNode.HasChildren = false;
                tree.Add(deletedNode);

                var awatingNode = XmlTreeNode.Create(this);
                awatingNode.NodeID = "10";
                awatingNode.NodeType = string.Empty;
                awatingNode.Text = "Awaiting Jobs";
                awatingNode.Action = "#";
                awatingNode.Action = "javascript:openPage('/umbraco/backoffice/Plugins/hangfire/jobs/awaiting');";
                awatingNode.Icon = "~/App_Plugins/Tools/Hangfire/hangfire.png";
                awatingNode.HasChildren = false;
                tree.Add(awatingNode);
            }
        }

        public override void RenderJS(ref StringBuilder Javascript)
        {
            var adminJs = $"function openPage(url){{UmbClientMgr.contentFrame(url);}}";

            Javascript.Append(adminJs);
        }
    }
}