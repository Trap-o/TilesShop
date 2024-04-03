using System;
using System.Text;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            bool userAutorized;
            bool isAdmin = false;
            {
                {
                    userAutorized = false;

                    string[] loginList = { "admin", "ivanova", "petr", "serg", "vasilisa", "semyon" };
                    string[] passwordList = { "1534", "9841", "1489", "6673", "2342", "6585" };

                    int authorizationAttemptCounter = 0;
                    const int ALLOWABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS = 3;
                    bool authorizationAttemptAvailable = authorizationAttemptCounter < ALLOWABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS;

                    while (authorizationAttemptAvailable)
                    {
                        string login, password;
                        {
                            Console.Write("Введіть логін: ");
                            login = Console.ReadLine();
                            Console.Write("Введіть пароль: ");
                            password = Console.ReadLine();
                        }
                        {
                            int index = 0;

                            while (index < loginList.Length && index < passwordList.Length)
                            {
                                bool loginMatched, passwordMatched;
                                {
                                    string currentLoginByIndex = loginList[index];
                                    loginMatched = currentLoginByIndex == login;
                                    string currentPasswordByIndex = passwordList[index];
                                    passwordMatched = currentPasswordByIndex == password;
                                }

                                if (loginMatched && passwordMatched)
                                {
                                    userAutorized = true;
                                    break;
                                }
                                else
                                {
                                    index++;
                                }
                            }

                            if (userAutorized == true)
                            {
                                Console.WriteLine($"Вітаємо, {login}!\n");
                                if(login == "admin")
                                    isAdmin = true;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Неправильний логін чи пароль!\n");
                                ++authorizationAttemptCounter;
                            }

                            if (authorizationAttemptAvailable != authorizationAttemptCounter < ALLOWABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS)
                            {
                                Console.WriteLine("Закінчились спроби входу!");
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }

                while (userAutorized)
                {
                    string countryCode;
                    decimal tileQuontiti, tilePrice;
                    // countryCode, tileQuontiti, tilePrice = RunInputUserInterface ()
                    {
                        Console.WriteLine("Натисність Enter для початку обслуговування нового клієнта.");
                        Console.ReadKey();
                        Console.Clear();

                        const string COUNTRY_CODES =
                            "===========================================================\n" +
                            "Азербайджан (994) |  Латвія      (371) | Туркменія    (993)\n" +
                            "Арменія     (374) |  Литва       (370) | Узбекистан   (998)\n" +
                            "Грузія      (995) |  Молдова     (373) | Україна      (380)\n" +
                            "Казахстан   (007) |  Польща      (049) | Естонія      (372)\n" +
                            "Киргізія    (996) |  Таджикістан (992) |                   \n" +
                            "-----------------------------------------------------------";

                        Console.WriteLine(COUNTRY_CODES);

                        // countryCode = ProcessCountryCode (countryCode)
                        {
                            bool countryCodeIsCorrect;

                            do
                            {
                                Console.Write("Телефонний код країни: ");
                                countryCode = Console.ReadLine();

                                // countryCodeIsCorrect = CheckCountryCode (countryCode)
                                {
                                    const string AZERBAIJAN_CODE = "994", ARMENIA_CODE = "374",
                                                 GEORGIA_CODE = "995", KAZAKHSTAN_CODE = "007", KYRGYZSTAN_CODE = "996",
                                                 LATVIA_CODE = "371", LITHUANIA_CODE = "370", MOLDOVA_CODE = "373",
                                                 POLAND_CODE = "049", TAJIKISTAN_CODE = "992", TURKMENISTAN_CODE = "993",
                                                 UZBEKISTAN_CODE = "998", UKRAINE_CODE = "380", ESTONIA_CODE = "372";

                                    switch (countryCode)
                                    {
                                        case AZERBAIJAN_CODE:
                                        case ARMENIA_CODE:
                                        case GEORGIA_CODE:
                                        case KAZAKHSTAN_CODE:
                                        case KYRGYZSTAN_CODE:
                                        case LATVIA_CODE:
                                        case LITHUANIA_CODE:
                                        case MOLDOVA_CODE:
                                        case POLAND_CODE:
                                        case TAJIKISTAN_CODE:
                                        case TURKMENISTAN_CODE:
                                        case UZBEKISTAN_CODE:
                                        case UKRAINE_CODE:
                                        case ESTONIA_CODE:
                                            {
                                                countryCodeIsCorrect = true;
                                                break;
                                            }
                                        default:
                                            {
                                                countryCodeIsCorrect = false;
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine($"Ви ввели неіснуючий код: {countryCode}!");
                                                Console.ForegroundColor = ConsoleColor.Gray;
                                                break;
                                            }
                                    }
                                }
                            }
                            while (countryCodeIsCorrect == false);

                        }
                        Console.Write("Кількість плитки: ");
                        string stringQuontiti = Console.ReadLine();
                        tileQuontiti = Convert.ToDecimal(stringQuontiti);

                        if (isAdmin == true)
                        {
                            Console.Write("Ціна за 1 кв.м. плитки: ");
                            tilePrice = Convert.ToDecimal(Console.ReadLine());
                        }
                        else
                            tilePrice = 100;               
                        
                    }

                    decimal rate;
                    // rate = CalculatePriceRate (countryCode)
                    {
                        
                        const string AZERBAIJAN_CODE = "994", ARMENIA_CODE = "374",
                                                 GEORGIA_CODE = "995", KAZAKHSTAN_CODE = "007", KYRGYZSTAN_CODE = "996",
                                                 LATVIA_CODE = "371", LITHUANIA_CODE = "370", MOLDOVA_CODE = "373",
                                                 POLAND_CODE = "049", TAJIKISTAN_CODE = "992", TURKMENISTAN_CODE = "993",
                                                 UZBEKISTAN_CODE = "998", UKRAINE_CODE = "380", ESTONIA_CODE = "372";

                        switch (countryCode)
                        {
                            case AZERBAIJAN_CODE:
                                {
                                    const decimal AZERBAIJAN_RATE = 1.1m;
                                    rate = AZERBAIJAN_RATE;
                                    break;
                                }
                            case ARMENIA_CODE:
                                {
                                    const decimal ARMENIA_RATE = 1m;
                                    rate = ARMENIA_RATE;
                                    break;
                                }
                            case GEORGIA_CODE:
                                {
                                    const decimal GEORGIA_RATE = 1.1m;
                                    rate = GEORGIA_RATE;
                                    break;
                                }
                            case KAZAKHSTAN_CODE:
                                {
                                    const decimal KAZAKHSTAN_RATE = 1m;
                                    rate = KAZAKHSTAN_RATE;
                                    break;
                                }
                            case KYRGYZSTAN_CODE:
                                {
                                    const decimal KYRGYZSTAN_RATE = 0.9m;
                                    rate = KYRGYZSTAN_RATE;
                                    break;
                                }
                            case MOLDOVA_CODE:
                                {
                                    const decimal MOLDOVA_RATE = 0.97m;
                                    rate = MOLDOVA_RATE;
                                    break;
                                }
                            case TAJIKISTAN_CODE:
                                {
                                    const decimal TAJIKISTAN_RATE = 0.88m;
                                    rate = TAJIKISTAN_RATE;
                                    break;
                                }
                            case TURKMENISTAN_CODE:
                                {
                                    const decimal TURKMENISTAN_RATE = 0.88m;
                                    rate = TURKMENISTAN_RATE;
                                    break;
                                }
                            case UZBEKISTAN_CODE:
                                {
                                    const decimal UZBEKISTAN_RATE = 0.98m;
                                    rate = UZBEKISTAN_RATE;
                                    break;
                                }
                            case UKRAINE_CODE:
                                {
                                    const decimal UKRAINE_RATE = 0.95m;
                                    rate = UKRAINE_RATE;
                                    break;
                                }
                            case POLAND_CODE:
                            case LATVIA_CODE:
                            case LITHUANIA_CODE:
                            case ESTONIA_CODE:
                                {
                                    const decimal LATVIA_LITHUANIA_ESTONIA_RATE = 1.12m;
                                    rate = LATVIA_LITHUANIA_ESTONIA_RATE;
                                    break;
                                }
                            default:
                                {
                                    rate = 0;
                                    break;
                                }
                        }
                    }

                    decimal tilePriceWithRate = tilePrice * rate;
                    decimal tileCost = tileQuontiti * tilePriceWithRate; // грн.

                    decimal discount; // грн.
                    {
                        decimal discountPersentage; // %
                        {
                            bool discount10PctAvailable, discount30PctAvailable;
                            {
                                const decimal MIN_TILE_QTY_FOR_DISCOUNT_10_PCT = 500,
                                              MIN_TILE_QTY_FOR_DISCOUNT_30_PCT = 1000; // м.кв.

                                discount10PctAvailable = tileQuontiti >= MIN_TILE_QTY_FOR_DISCOUNT_10_PCT &&
                                                         tileQuontiti < MIN_TILE_QTY_FOR_DISCOUNT_30_PCT;

                                discount30PctAvailable = tileQuontiti >= MIN_TILE_QTY_FOR_DISCOUNT_30_PCT;
                            }

                            if (discount10PctAvailable)
                            {
                                discountPersentage = 10; // %
                                Console.WriteLine("Знижка за кількість – 10%.");
                            }
                            else if (discount30PctAvailable)
                            {
                                discountPersentage = 30; // %
                                Console.WriteLine("Знижка за кількість – 30%.");
                            }
                            else
                            {
                                discountPersentage = 0; // %
                                Console.WriteLine("Знижка за кількість не застосована.");
                            }
                        }

                        discount = tileCost / 100 * discountPersentage;
                    }

                    decimal paymentAmount = tileCost - discount;

                    // RunOutputUserInterface (tilePriceWithRate, tileCost, discount, paymentAmount)
                    {
                        Console.WriteLine($"\nЦіна з коефіцієнтом         : {tilePriceWithRate} грн.");
                        Console.WriteLine($"Загальна вартість плитки    : {tileCost} грн.");
                        Console.WriteLine($"Знижка                      : {discount} грн.");
                        Console.WriteLine($"Сума до оплати              : {paymentAmount} грн.\n");
                    }
                }
            }
        }
    }
}