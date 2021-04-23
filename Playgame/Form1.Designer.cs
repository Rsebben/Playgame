
namespace Playgame
{
    partial class playGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startGame = new System.Windows.Forms.Button();
            this.countdown = new System.Windows.Forms.Label();
            this.go = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startGame
            // 
            this.startGame.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.startGame.FlatAppearance.BorderSize = 2;
            this.startGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.startGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGame.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.ForeColor = System.Drawing.Color.White;
            this.startGame.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.startGame.Location = new System.Drawing.Point(344, 138);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(119, 32);
            this.startGame.TabIndex = 0;
            this.startGame.Text = "Start Game!";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // countdown
            // 
            this.countdown.BackColor = System.Drawing.Color.Black;
            this.countdown.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown.ForeColor = System.Drawing.Color.White;
            this.countdown.Location = new System.Drawing.Point(251, 298);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(212, 23);
            this.countdown.TabIndex = 1;
            this.countdown.Text = "The Game Will Start In ...  3";
            this.countdown.Visible = false;
            // 
            // go
            // 
            this.go.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go.ForeColor = System.Drawing.Color.White;
            this.go.Location = new System.Drawing.Point(379, 204);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(100, 64);
            this.go.TabIndex = 2;
            this.go.Text = "Go!!";
            this.go.Visible = false;
            this.go.Click += new System.EventHandler(this.label1_Click);
            // 
            // playGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.go);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.startGame);
            this.Name = "playGame";
            this.Text = "Play Game!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Label go;
    }
}

