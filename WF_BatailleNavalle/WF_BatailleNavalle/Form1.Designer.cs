﻿namespace WF_BatailleNavalle
{
    partial class FrmBatailleNavalle
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FrmBatailleNavalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 533);
            this.Name = "FrmBatailleNavalle";
            this.Text = "Bataille navalle";
            this.Load += new System.EventHandler(this.FrmBatailleNavalle_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmBatailleNavalle_Paint);
            this.ResumeLayout(false);


        }

        #endregion
    }
}

