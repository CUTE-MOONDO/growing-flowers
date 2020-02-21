namespace InspectorProgram
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Card = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DevQ = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Determinants = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ForQ = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Pair = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Contents = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PopR = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Zscore = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.G_PHR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Card,
            this.Location,
            this.DevQ,
            this.Determinants,
            this.ForQ,
            this.Pair,
            this.Contents,
            this.PopR,
            this.Zscore,
            this.G_PHR});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1144, 459);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridView1_RowPostPaint);
            // 
            // Num
            // 
            this.Num.HeaderText = "Num";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Width = 40;
            // 
            // Card
            // 
            this.Card.HeaderText = "Card";
            this.Card.Items.AddRange(new object[] {
            "Ⅰ",
            "Ⅱ",
            "Ⅲ",
            "Ⅳ",
            "Ⅴ",
            "Ⅵ",
            "Ⅶ",
            "Ⅷ",
            "Ⅸ",
            "Ⅹ"});
            this.Card.Name = "Card";
            this.Card.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Card.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Card.ToolTipText = "카드번호";
            this.Card.Width = 40;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Items.AddRange(new object[] {
            "W",
            "D",
            "Dd",
            "WS",
            "DS",
            "DdS"});
            this.Location.Name = "Location";
            this.Location.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Location.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Location.ToolTipText = "반응위치";
            // 
            // DevQ
            // 
            this.DevQ.HeaderText = "DQ";
            this.DevQ.Items.AddRange(new object[] {
            "+",
            "o",
            "v/+",
            "v"});
            this.DevQ.Name = "DevQ";
            this.DevQ.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DevQ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DevQ.ToolTipText = "발달질";
            // 
            // Determinants
            // 
            this.Determinants.HeaderText = "Determinants";
            this.Determinants.Items.AddRange(new object[] {
            "F",
            "Ma",
            "Mp",
            "Ma-p",
            "FMa",
            "FMp",
            "FMa-p",
            "m\'a",
            "m\'p",
            "m\'a-p",
            "FC",
            "CF",
            "C",
            "Cn",
            "FC\'",
            "C\'F",
            "C\'",
            "FT",
            "TF",
            "T",
            "FV",
            "VF",
            "V",
            "FY",
            "YF",
            "Y",
            "FD",
            "Fr",
            "rF"});
            this.Determinants.Name = "Determinants";
            this.Determinants.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Determinants.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Determinants.ToolTipText = "결정요인";
            // 
            // ForQ
            // 
            this.ForQ.HeaderText = "FQ";
            this.ForQ.Items.AddRange(new object[] {
            "+",
            "o",
            "u",
            "-",
            "none"});
            this.ForQ.Name = "ForQ";
            this.ForQ.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ForQ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ForQ.ToolTipText = "형태질";
            // 
            // Pair
            // 
            this.Pair.HeaderText = "Pair";
            this.Pair.Items.AddRange(new object[] {
            "(2)"});
            this.Pair.Name = "Pair";
            this.Pair.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Pair.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Pair.ToolTipText = "쌍반응";
            // 
            // Contents
            // 
            this.Contents.HeaderText = "Contents";
            this.Contents.Items.AddRange(new object[] {
            "H",
            "(H)",
            "Hd",
            "(Hd)",
            "Hx",
            "A",
            "(A)",
            "Ad",
            "(Ad)",
            "An",
            "Art",
            "Ay",
            "Bl",
            "Bt",
            "Cg",
            "Cl",
            "Ex",
            "Fd",
            "Fi",
            "Ge",
            "Hh",
            "Ls",
            "Na",
            "Sc",
            "Sx",
            "Xy",
            "Id"});
            this.Contents.Name = "Contents";
            this.Contents.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Contents.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Contents.ToolTipText = "반응내용";
            // 
            // PopR
            // 
            this.PopR.HeaderText = "PR";
            this.PopR.Items.AddRange(new object[] {
            "P"});
            this.PopR.Name = "PopR";
            this.PopR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PopR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PopR.ToolTipText = "평범반응";
            // 
            // Zscore
            // 
            this.Zscore.HeaderText = "Zscore";
            this.Zscore.Items.AddRange(new object[] {
            "ZW",
            "ZA",
            "ZD",
            "ZS"});
            this.Zscore.Name = "Zscore";
            this.Zscore.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Zscore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Zscore.ToolTipText = "특수점수";
            // 
            // G_PHR
            // 
            this.G_PHR.HeaderText = "G/PHR";
            this.G_PHR.Name = "G_PHR";
            this.G_PHR.ReadOnly = true;
            this.G_PHR.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.G_PHR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 459);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewComboBoxColumn Card;
        private System.Windows.Forms.DataGridViewComboBoxColumn Location;
        private System.Windows.Forms.DataGridViewComboBoxColumn DevQ;
        private System.Windows.Forms.DataGridViewComboBoxColumn Determinants;
        private System.Windows.Forms.DataGridViewComboBoxColumn ForQ;
        private System.Windows.Forms.DataGridViewComboBoxColumn Pair;
        private System.Windows.Forms.DataGridViewComboBoxColumn Contents;
        private System.Windows.Forms.DataGridViewComboBoxColumn PopR;
        private System.Windows.Forms.DataGridViewComboBoxColumn Zscore;
        private System.Windows.Forms.DataGridViewTextBoxColumn G_PHR;
    }
}

