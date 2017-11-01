namespace SqlExplorer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rPOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gMADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lista = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tFiltro = new System.Windows.Forms.TextBox();
            this.texto = new System.Windows.Forms.RichTextBox();
            this.entornoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desarrolloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explotaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.entornoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.conectarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rPOSToolStripMenuItem,
            this.gMADToolStripMenuItem});
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.conectarToolStripMenuItem.Text = "&Conectar";
            // 
            // rPOSToolStripMenuItem
            // 
            this.rPOSToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rPOSToolStripMenuItem.Name = "rPOSToolStripMenuItem";
            this.rPOSToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rPOSToolStripMenuItem.Tag = "RPOS";
            this.rPOSToolStripMenuItem.Text = "&RPOS";
            this.rPOSToolStripMenuItem.Click += new System.EventHandler(this.conexionToolStripMenuItem_Click);
            // 
            // gMADToolStripMenuItem
            // 
            this.gMADToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.gMADToolStripMenuItem.Name = "gMADToolStripMenuItem";
            this.gMADToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gMADToolStripMenuItem.Tag = "CGAL01DB01";
            this.gMADToolStripMenuItem.Text = "&CGAL01DB01";
            this.gMADToolStripMenuItem.Click += new System.EventHandler(this.conexionToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lista);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.tFiltro);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.texto);
            this.splitContainer1.Size = new System.Drawing.Size(805, 452);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.TabIndex = 1;
            // 
            // lista
            // 
            this.lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(3, 26);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(262, 420);
            this.lista.TabIndex = 2;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Filtro";
            // 
            // tFiltro
            // 
            this.tFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tFiltro.Location = new System.Drawing.Point(38, 1);
            this.tFiltro.Name = "tFiltro";
            this.tFiltro.Size = new System.Drawing.Size(227, 20);
            this.tFiltro.TabIndex = 0;
            this.tFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tFiltro_KeyPress);
            // 
            // texto
            // 
            this.texto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.texto.Location = new System.Drawing.Point(0, 0);
            this.texto.Name = "texto";
            this.texto.ReadOnly = true;
            this.texto.Size = new System.Drawing.Size(533, 452);
            this.texto.TabIndex = 0;
            this.texto.Text = "";
            // 
            // entornoToolStripMenuItem
            // 
            this.entornoToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.entornoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desarrolloToolStripMenuItem,
            this.puenteToolStripMenuItem,
            this.explotaciónToolStripMenuItem});
            this.entornoToolStripMenuItem.Enabled = false;
            this.entornoToolStripMenuItem.Name = "entornoToolStripMenuItem";
            this.entornoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.entornoToolStripMenuItem.Text = "&Entorno";
            // 
            // desarrolloToolStripMenuItem
            // 
            this.desarrolloToolStripMenuItem.Checked = true;
            this.desarrolloToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.desarrolloToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.desarrolloToolStripMenuItem.Name = "desarrolloToolStripMenuItem";
            this.desarrolloToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.desarrolloToolStripMenuItem.Tag = "D";
            this.desarrolloToolStripMenuItem.Text = "&Desarrollo";
            this.desarrolloToolStripMenuItem.Click += new System.EventHandler(this.entornoToolStripMenuItem_Click);
            // 
            // puenteToolStripMenuItem
            // 
            this.puenteToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.puenteToolStripMenuItem.Name = "puenteToolStripMenuItem";
            this.puenteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.puenteToolStripMenuItem.Tag = "P";
            this.puenteToolStripMenuItem.Text = "&Puente";
            this.puenteToolStripMenuItem.Click += new System.EventHandler(this.entornoToolStripMenuItem_Click);
            // 
            // explotaciónToolStripMenuItem
            // 
            this.explotaciónToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.explotaciónToolStripMenuItem.Name = "explotaciónToolStripMenuItem";
            this.explotaciónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.explotaciónToolStripMenuItem.Tag = "E";
            this.explotaciónToolStripMenuItem.Text = "&Explotación";
            this.explotaciónToolStripMenuItem.Click += new System.EventHandler(this.entornoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 476);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Explorador de PA\'s";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rPOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gMADToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tFiltro;
        private System.Windows.Forms.RichTextBox texto;
        private System.Windows.Forms.ToolStripMenuItem entornoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desarrolloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explotaciónToolStripMenuItem;
    }
}

