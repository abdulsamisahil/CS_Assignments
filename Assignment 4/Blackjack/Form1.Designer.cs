namespace Blackjack
{
    partial class Form1
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
            this.lbl_valueOfCards_player = new System.Windows.Forms.Label();
            this.btn_dealNewRound = new System.Windows.Forms.Button();
            this.btn_shuffle = new System.Windows.Forms.Button();
            this.lbl_playerCards = new System.Windows.Forms.Label();
            this.btn_player1_hit = new System.Windows.Forms.Button();
            this.btn_newGame = new System.Windows.Forms.Button();
            this.lbl_staticCardLeft = new System.Windows.Forms.Label();
            this.lbl_playerName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_playerShowValue = new System.Windows.Forms.Label();
            this.btn_playerStand = new System.Windows.Forms.Button();
            this.lbl_staticCards_player = new System.Windows.Forms.Label();
            this.lbl_staticValue_player = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_dealerShowValue = new System.Windows.Forms.Label();
            this.lbl_valueOfCards_dealer = new System.Windows.Forms.Label();
            this.lbl_dealerCards = new System.Windows.Forms.Label();
            this.lbl_staticCards_dealer = new System.Windows.Forms.Label();
            this.lbl_staticValue_dealer = new System.Windows.Forms.Label();
            this.lbl_dealer = new System.Windows.Forms.Label();
            this.lbl_cardsLeft = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_valueOfCards_player
            // 
            this.lbl_valueOfCards_player.AutoSize = true;
            this.lbl_valueOfCards_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_valueOfCards_player.Location = new System.Drawing.Point(285, 137);
            this.lbl_valueOfCards_player.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_valueOfCards_player.Name = "lbl_valueOfCards_player";
            this.lbl_valueOfCards_player.Size = new System.Drawing.Size(200, 33);
            this.lbl_valueOfCards_player.TabIndex = 1;
            this.lbl_valueOfCards_player.Text = "valueOfcards";
            // 
            // btn_dealNewRound
            // 
            this.btn_dealNewRound.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_dealNewRound.Location = new System.Drawing.Point(1280, 165);
            this.btn_dealNewRound.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_dealNewRound.Name = "btn_dealNewRound";
            this.btn_dealNewRound.Size = new System.Drawing.Size(170, 96);
            this.btn_dealNewRound.TabIndex = 2;
            this.btn_dealNewRound.Text = "New Round";
            this.btn_dealNewRound.UseVisualStyleBackColor = false;
            this.btn_dealNewRound.Click += new System.EventHandler(this.btn_dealNewRound_Click);
            // 
            // btn_shuffle
            // 
            this.btn_shuffle.Location = new System.Drawing.Point(1477, 165);
            this.btn_shuffle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_shuffle.Name = "btn_shuffle";
            this.btn_shuffle.Size = new System.Drawing.Size(173, 96);
            this.btn_shuffle.TabIndex = 3;
            this.btn_shuffle.Text = "shuffle";
            this.btn_shuffle.UseVisualStyleBackColor = true;
            this.btn_shuffle.Click += new System.EventHandler(this.bt_shuffle_Click);
            // 
            // lbl_playerCards
            // 
            this.lbl_playerCards.AutoSize = true;
            this.lbl_playerCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_playerCards.Location = new System.Drawing.Point(98, 252);
            this.lbl_playerCards.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_playerCards.Name = "lbl_playerCards";
            this.lbl_playerCards.Size = new System.Drawing.Size(156, 29);
            this.lbl_playerCards.TabIndex = 4;
            this.lbl_playerCards.Text = "player cards";
            // 
            // btn_player1_hit
            // 
            this.btn_player1_hit.Location = new System.Drawing.Point(25, 583);
            this.btn_player1_hit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_player1_hit.Name = "btn_player1_hit";
            this.btn_player1_hit.Size = new System.Drawing.Size(193, 127);
            this.btn_player1_hit.TabIndex = 5;
            this.btn_player1_hit.Text = "hit";
            this.btn_player1_hit.UseVisualStyleBackColor = true;
            this.btn_player1_hit.Click += new System.EventHandler(this.btn_player_hit_Click);
            // 
            // btn_newGame
            // 
            this.btn_newGame.BackColor = System.Drawing.Color.Lime;
            this.btn_newGame.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_newGame.Location = new System.Drawing.Point(20, 23);
            this.btn_newGame.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_newGame.Name = "btn_newGame";
            this.btn_newGame.Size = new System.Drawing.Size(170, 96);
            this.btn_newGame.TabIndex = 6;
            this.btn_newGame.Text = "New Game";
            this.btn_newGame.UseVisualStyleBackColor = false;
            this.btn_newGame.Click += new System.EventHandler(this.btn_newGame_Click);
            // 
            // lbl_staticCardLeft
            // 
            this.lbl_staticCardLeft.AutoSize = true;
            this.lbl_staticCardLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_staticCardLeft.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_staticCardLeft.Location = new System.Drawing.Point(1280, 300);
            this.lbl_staticCardLeft.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_staticCardLeft.Name = "lbl_staticCardLeft";
            this.lbl_staticCardLeft.Size = new System.Drawing.Size(193, 25);
            this.lbl_staticCardLeft.TabIndex = 7;
            this.lbl_staticCardLeft.Text = "Cards left in deck: ";
            // 
            // lbl_playerName
            // 
            this.lbl_playerName.AutoSize = true;
            this.lbl_playerName.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_playerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_playerName.Location = new System.Drawing.Point(173, 62);
            this.lbl_playerName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_playerName.Name = "lbl_playerName";
            this.lbl_playerName.Size = new System.Drawing.Size(199, 37);
            this.lbl_playerName.TabIndex = 8;
            this.lbl_playerName.Text = "playerName";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_playerShowValue);
            this.groupBox1.Controls.Add(this.btn_playerStand);
            this.groupBox1.Controls.Add(this.lbl_staticCards_player);
            this.groupBox1.Controls.Add(this.lbl_staticValue_player);
            this.groupBox1.Controls.Add(this.lbl_playerCards);
            this.groupBox1.Controls.Add(this.btn_player1_hit);
            this.groupBox1.Controls.Add(this.lbl_playerName);
            this.groupBox1.Controls.Add(this.lbl_valueOfCards_player);
            this.groupBox1.Location = new System.Drawing.Point(20, 156);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(607, 735);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Player";
            // 
            // lbl_playerShowValue
            // 
            this.lbl_playerShowValue.AutoSize = true;
            this.lbl_playerShowValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_playerShowValue.Location = new System.Drawing.Point(200, 452);
            this.lbl_playerShowValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_playerShowValue.Name = "lbl_playerShowValue";
            this.lbl_playerShowValue.Size = new System.Drawing.Size(263, 52);
            this.lbl_playerShowValue.TabIndex = 11;
            this.lbl_playerShowValue.Text = "playerValue";
            // 
            // btn_playerStand
            // 
            this.btn_playerStand.Location = new System.Drawing.Point(388, 583);
            this.btn_playerStand.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_playerStand.Name = "btn_playerStand";
            this.btn_playerStand.Size = new System.Drawing.Size(193, 127);
            this.btn_playerStand.TabIndex = 11;
            this.btn_playerStand.Text = "Stand";
            this.btn_playerStand.UseVisualStyleBackColor = true;
            this.btn_playerStand.Click += new System.EventHandler(this.btn_playerStand_Click);
            // 
            // lbl_staticCards_player
            // 
            this.lbl_staticCards_player.AutoSize = true;
            this.lbl_staticCards_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_staticCards_player.Location = new System.Drawing.Point(187, 213);
            this.lbl_staticCards_player.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_staticCards_player.Name = "lbl_staticCards_player";
            this.lbl_staticCards_player.Size = new System.Drawing.Size(190, 29);
            this.lbl_staticCards_player.TabIndex = 10;
            this.lbl_staticCards_player.Text = "Players Cards: ";
            // 
            // lbl_staticValue_player
            // 
            this.lbl_staticValue_player.AutoSize = true;
            this.lbl_staticValue_player.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_staticValue_player.Location = new System.Drawing.Point(143, 137);
            this.lbl_staticValue_player.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_staticValue_player.Name = "lbl_staticValue_player";
            this.lbl_staticValue_player.Size = new System.Drawing.Size(120, 33);
            this.lbl_staticValue_player.TabIndex = 9;
            this.lbl_staticValue_player.Text = "Points: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_dealerShowValue);
            this.groupBox2.Controls.Add(this.lbl_valueOfCards_dealer);
            this.groupBox2.Controls.Add(this.lbl_dealerCards);
            this.groupBox2.Controls.Add(this.lbl_staticCards_dealer);
            this.groupBox2.Controls.Add(this.lbl_staticValue_dealer);
            this.groupBox2.Controls.Add(this.lbl_dealer);
            this.groupBox2.Location = new System.Drawing.Point(637, 156);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Size = new System.Drawing.Size(593, 735);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // lbl_dealerShowValue
            // 
            this.lbl_dealerShowValue.AutoSize = true;
            this.lbl_dealerShowValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dealerShowValue.Location = new System.Drawing.Point(180, 452);
            this.lbl_dealerShowValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_dealerShowValue.Name = "lbl_dealerShowValue";
            this.lbl_dealerShowValue.Size = new System.Drawing.Size(265, 52);
            this.lbl_dealerShowValue.TabIndex = 5;
            this.lbl_dealerShowValue.Text = "dealerValue";
            // 
            // lbl_valueOfCards_dealer
            // 
            this.lbl_valueOfCards_dealer.AutoSize = true;
            this.lbl_valueOfCards_dealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_valueOfCards_dealer.Location = new System.Drawing.Point(285, 137);
            this.lbl_valueOfCards_dealer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_valueOfCards_dealer.Name = "lbl_valueOfCards_dealer";
            this.lbl_valueOfCards_dealer.Size = new System.Drawing.Size(206, 33);
            this.lbl_valueOfCards_dealer.TabIndex = 4;
            this.lbl_valueOfCards_dealer.Text = "valueOfCards";
            // 
            // lbl_dealerCards
            // 
            this.lbl_dealerCards.AutoSize = true;
            this.lbl_dealerCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_dealerCards.Location = new System.Drawing.Point(95, 252);
            this.lbl_dealerCards.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_dealerCards.Name = "lbl_dealerCards";
            this.lbl_dealerCards.Size = new System.Drawing.Size(159, 29);
            this.lbl_dealerCards.TabIndex = 3;
            this.lbl_dealerCards.Text = "dealer cards";
            // 
            // lbl_staticCards_dealer
            // 
            this.lbl_staticCards_dealer.AutoSize = true;
            this.lbl_staticCards_dealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_staticCards_dealer.Location = new System.Drawing.Point(173, 213);
            this.lbl_staticCards_dealer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_staticCards_dealer.Name = "lbl_staticCards_dealer";
            this.lbl_staticCards_dealer.Size = new System.Drawing.Size(181, 29);
            this.lbl_staticCards_dealer.TabIndex = 2;
            this.lbl_staticCards_dealer.Text = "Dealer Cards: ";
            // 
            // lbl_staticValue_dealer
            // 
            this.lbl_staticValue_dealer.AutoSize = true;
            this.lbl_staticValue_dealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_staticValue_dealer.Location = new System.Drawing.Point(143, 137);
            this.lbl_staticValue_dealer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_staticValue_dealer.Name = "lbl_staticValue_dealer";
            this.lbl_staticValue_dealer.Size = new System.Drawing.Size(120, 33);
            this.lbl_staticValue_dealer.TabIndex = 1;
            this.lbl_staticValue_dealer.Text = "Points: ";
            // 
            // lbl_dealer
            // 
            this.lbl_dealer.AutoSize = true;
            this.lbl_dealer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_dealer.Location = new System.Drawing.Point(210, 62);
            this.lbl_dealer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_dealer.Name = "lbl_dealer";
            this.lbl_dealer.Size = new System.Drawing.Size(116, 37);
            this.lbl_dealer.TabIndex = 0;
            this.lbl_dealer.Text = "Dealer";
            // 
            // lbl_cardsLeft
            // 
            this.lbl_cardsLeft.AutoSize = true;
            this.lbl_cardsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_cardsLeft.Location = new System.Drawing.Point(1517, 300);
            this.lbl_cardsLeft.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_cardsLeft.Name = "lbl_cardsLeft";
            this.lbl_cardsLeft.Size = new System.Drawing.Size(93, 25);
            this.lbl_cardsLeft.TabIndex = 11;
            this.lbl_cardsLeft.Text = "kortKvar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1280, 369);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(513, 299);
            this.dataGridView1.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1280, 692);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(513, 299);
            this.dataGridView2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1818, 1035);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_cardsLeft);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_newGame);
            this.Controls.Add(this.btn_shuffle);
            this.Controls.Add(this.btn_dealNewRound);
            this.Controls.Add(this.lbl_staticCardLeft);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_valueOfCards_player;
        private System.Windows.Forms.Button btn_dealNewRound;
        private System.Windows.Forms.Button btn_shuffle;
        private System.Windows.Forms.Label lbl_playerCards;
        private System.Windows.Forms.Button btn_player1_hit;
        private System.Windows.Forms.Button btn_newGame;
        private System.Windows.Forms.Label lbl_staticCardLeft;
        private System.Windows.Forms.Label lbl_playerName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_staticValue_player;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_staticValue_dealer;
        private System.Windows.Forms.Label lbl_dealer;
        private System.Windows.Forms.Label lbl_staticCards_player;
        private System.Windows.Forms.Label lbl_staticCards_dealer;
        private System.Windows.Forms.Label lbl_valueOfCards_dealer;
        private System.Windows.Forms.Label lbl_dealerCards;
        private System.Windows.Forms.Button btn_playerStand;
        private System.Windows.Forms.Label lbl_playerShowValue;
        private System.Windows.Forms.Label lbl_cardsLeft;
        private System.Windows.Forms.Label lbl_dealerShowValue;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

