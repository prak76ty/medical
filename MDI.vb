Public Class MDI


    Private Sub PurchaseOrderReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseOrderReportToolStripMenuItem.Click
        rptPurchaseMasterReport.MdiParent = Me
        rptPurchaseMasterReport.Show()
    End Sub

    Private Sub ProductMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductMasterToolStripMenuItem.Click
        Product_Master.MdiParent = Me
        Product_Master.Show()
    End Sub

    Private Sub DistibuterMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DistibuterMasterToolStripMenuItem.Click
        Distributer_Master.MdiParent = Me
        Distributer_Master.Show()
    End Sub

    Private Sub CustmerMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustmerMasterToolStripMenuItem.Click
        Customer_Master.MdiParent = Me
        Customer_Master.Show()
    End Sub

    Private Sub MDI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DocterMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocterMasterToolStripMenuItem.Click
        Dr_Master.MdiParent = Me
        Dr_Master.Show()
    End Sub

    Private Sub PuToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PuToolStripMenuItem.Click
        Purchase_order_master.MdiParent = Me
        Purchase_order_master.Show()
    End Sub

    Private Sub ProductMasterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductMasterToolStripMenuItem1.Click
        rptproduct_mastervb.MdiParent = Me
        rptproduct_mastervb.Show()
    End Sub

    Private Sub PurchaseReturnToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReturnToolStripMenuItem.Click
        Purchase_order_delivery.MdiParent = Me
        Purchase_order_delivery.Show()

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        purchase_Return.MdiParent = Me
        purchase_Return.Show()
    End Sub

    Private Sub SelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelToolStripMenuItem.Click
        sales_order_master.MdiParent = Me
        sales_order_master.Show()
    End Sub

    Private Sub ExpansesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpansesToolStripMenuItem.Click
        Expanses.MdiParent = Me
        Expanses.Show()
    End Sub

    Private Sub DistibuterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DistibuterToolStripMenuItem.Click
        rptdistribut.MdiParent = Me
        rptdistribut.Show()

    End Sub

    Private Sub CustomerReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerReportToolStripMenuItem.Click
        rptcustmermaster.MdiParent = Me
        rptcustmermaster.Show()
    End Sub

    Private Sub MasterFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MasterFormToolStripMenuItem.Click

    End Sub

    Private Sub PToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PToolStripMenuItem.Click
        rptpurchase_or_delivery.MdiParent = Me
        rptpurchase_or_delivery.Show()
    End Sub

    Private Sub SalesOrderReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesOrderReportToolStripMenuItem.Click
        rptSaleMasterReport.MdiParent = Me
        rptSaleMasterReport.Show()

    End Sub

    Private Sub PurchaseReturnReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseReturnReportToolStripMenuItem.Click
        rpt_purchase_return.MdiParent = Me
        rpt_purchase_return.Show()

    End Sub

    Private Sub DocterReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocterReportToolStripMenuItem.Click
        rpt_Dr_master.MdiParent = Me
        rpt_Dr_master.Show()

    End Sub

    Private Sub ExpansesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpansesReportToolStripMenuItem.Click
        rpt_EXpanses.MdiParent = Me
        rpt_EXpanses.Show()

    End Sub
End Class