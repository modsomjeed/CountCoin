namespace CoinTDD
{
    public class Coin
    {
        public int CalculateCoinForNumber (int number) {
            var sum = number;
            var countCoin = 0;
            for (int i = 3; i > 0; i--)
            {
                var coin = sum/i;
                if (coin > 0) {
                        sum -= i;
                        ++countCoin;
                }
            }
            if (sum > 0) {
                for (int i = 3; i > 0; i--)
                {
                    if (sum > 0){ 
                        var coin = sum/i;
                        if (coin > 0) {
                            sum -= coin*i;
                            ++countCoin;
                        }
                    }
                }
            }
            return countCoin;
        }
    }
}