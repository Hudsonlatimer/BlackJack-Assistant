namespace BlackJack_Assistant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve user inputs
                int amountBet = int.Parse(txtAmountBet.Text);
                int sideBet = int.Parse(txtSideBet.Text);
                int numHands = int.Parse(txtNumHands.Text);

                // Handle the input for player sum with Aces
                string playerSumInput = txtPlayerSum.Text;
                int playerSum = GetPlayerSum(playerSumInput);

                int dealerCard = ParseCardValue(txtDealerCard.Text);
                int lastCard = ParseCardValue(txtLastCard.Text);

                // Check if player can split or double
                bool canSplit = chkCanSplit.Checked;
                bool canDouble = chkCanDouble.Checked;

                // Call the function to get Blackjack decision
                string decision = GetBlackjackDecision(playerSum, dealerCard, lastCard, canSplit, canDouble);

                // Display the result
                lblDecision.Text = $"AI Suggests: {decision}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter valid numbers in all fields.", "Error");
            }
        }

        // Function to parse card value, supporting Ace (A)
        private int ParseCardValue(string cardInput)
        {
            if (cardInput.Equals("A", StringComparison.OrdinalIgnoreCase))
            {
                return 11; // Treat Ace as 11 by default
            }
            if (int.TryParse(cardInput, out int cardValue))
            {
                return cardValue; // Return the integer value
            }
            throw new FormatException("Invalid card value.");
        }

        // Function to calculate the player's card sum from input (supports "6/16" format)
        private int GetPlayerSum(string playerSumInput)
        {
            string[] parts = playerSumInput.Split('/');
            if (parts.Length == 2)
            {
                int softTotal = ParseCardValue(parts[0]);
                int hardTotal = ParseCardValue(parts[1]);
                return softTotal; // Return the soft total (first number)
            }
            else if (playerSumInput.Equals("A", StringComparison.OrdinalIgnoreCase))
            {
                return 11; // Return 11 for Ace
            }
            else if (int.TryParse(playerSumInput, out int total))
            {
                return total; // If input is a single number, return it
            }
            else
            {
                throw new FormatException("Invalid format for player sum.");
            }
        }

        // Decision-making function
        private string GetBlackjackDecision(int playerSum, int dealerCard, int lastCard, bool canSplit, bool canDouble)
        {
            // Use a safe strategy to maximize profit
            if (playerSum == 21)
                return "Stand (Blackjack)";
            if (playerSum > 21)
                return "Bust!";

            // Safe strategy decisions based on common Blackjack strategies
            if (canSplit && playerSum == 20)
                return "Split"; // Split 10s
            if (canDouble && playerSum == 11)
                return "Double Down"; // Double on 11

            // Player's hard totals
            if (playerSum >= 17)
                return "Stand"; // Stand on hard 17 and higher
            if (playerSum == 16)
                return dealerCard < 7 ? "Stand" : "Hit"; // Stand against weak dealer card (2-6)
            if (playerSum == 15)
                return dealerCard < 7 ? "Stand" : "Hit"; // Similar logic for 15

            // Player's soft totals (Ace present)
            if (playerSum >= 13 && playerSum <= 17)
                return "Hit"; // Hit on soft totals 13-17

            // Default action
            return "Hit"; // Hit otherwise
        }
    }
}
