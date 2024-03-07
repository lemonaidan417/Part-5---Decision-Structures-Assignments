using System.Reflection.Emit;

namespace Part_5___Decision_Structures_Assignments
{
    internal class Program
    {
        public static void SimpleBankingMachine()
        {
            int transactionOption;

            double userAcctBalance, userDeposit, userWithdrawal;

            userAcctBalance = 150;

            Console.WriteLine("Hello, welcome to BoBTM (Bank of Blorb).");
            Console.WriteLine("________________________________________");
            Console.WriteLine();
            Console.WriteLine("Before you begin your transaction, we would like to" +
                " inform you that for using this BoBTM ATM, you will automatically be" +
                " charged a fee of $0.75 Blorbian Dollars.");
            Console.WriteLine();
            Console.WriteLine("Your transaction options are:");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdrawal");
            Console.WriteLine("3. Bill Payment");
            Console.WriteLine("4. Account Balance Update");
            Console.WriteLine();
            Console.Write("Please input the number of the transaction action that you would you like to do:");
            transactionOption = Convert.ToInt32(Console.ReadLine());

            if (userAcctBalance >= 0.75)
            {
                // Deposit
                if (transactionOption == 1)
                {
                    userAcctBalance = (userAcctBalance - 0.75);
                    Console.WriteLine("You chose deposit.");
                    Console.Write("Please input how much money you would like to deposit: ");
                    userDeposit = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    if (userDeposit >= 0)
                    {
                        userAcctBalance = userAcctBalance + userDeposit;
                        Console.WriteLine("Please wait while your money is deposited.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Your money has been deposited into your account.");
                        Console.WriteLine($"Your new account balance is ${userAcctBalance}");
                    }
                    else if (userDeposit < 0)
                    {
                        Console.WriteLine("You seem to have input a number smaller than 0,"
                            + " so I'm going to keep the number the same, but I will make it a positive.");
                        userDeposit = userDeposit * -1;
                        userAcctBalance = userAcctBalance + userDeposit;
                        Console.WriteLine("Please wait while your money is deposited.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Your money has been deposited into your account.");
                        Console.WriteLine($"Your new account balance is ${userAcctBalance}");
                    }
                }

                // Withdrawal
                else if (transactionOption == 2)
                {
                    userAcctBalance = (userAcctBalance - 0.75);
                    Console.WriteLine("You chose withdrawal.");
                    Console.Write("Please input how much money would you like to withdraw: ");
                    userWithdrawal = Convert.ToDouble(Console.ReadLine());

                    if (userWithdrawal >= 0.01)
                    {
                        userAcctBalance = userAcctBalance - userWithdrawal;
                        Console.WriteLine("Please wait while your money is prepared.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Your money is ready for you.");
                        Console.WriteLine($"Your new account balance is ${userAcctBalance}");
                    }
                    else if (userWithdrawal < 0)
                    {
                        Console.WriteLine("You seem to have input a number smaller than $0.01,"
                            + " so I'm going to keep the number the same, but I will make it a positive.");
                        userWithdrawal = userWithdrawal * -1;
                        userAcctBalance = userAcctBalance - userWithdrawal;
                        Console.WriteLine("Please wait while your money is prepared.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Your money is ready for you.");
                        Console.WriteLine($"Your new account balance is ${userAcctBalance}");
                    }
                }

                // Bill Payment
                else if (transactionOption == 3)
                {
                    int userBillChoice;
                    userAcctBalance = (userAcctBalance - 0.75);
                    Console.WriteLine("You chose bill payment.");
                    Console.WriteLine("You have 3 bills to pay.");
                    Console.WriteLine("Bill 1. $30.26");
                    Console.WriteLine("Bill 2. $103.74");
                    Console.WriteLine("Bill 3. $52.38");
                    Console.WriteLine("Please input the number associated with the bill that you would like to pay: ");
                    userBillChoice = Convert.ToInt32(Console.ReadLine());

                    if (userBillChoice == 1)
                    {
                        userAcctBalance -= 30.26;
                    }
                    else if (userBillChoice == 2)
                    {
                        userAcctBalance -= 103.74;
                    }
                    else if (userBillChoice == 3)
                    {
                        userAcctBalance -= 52.38;
                    }
                    Console.WriteLine($"Your new account balance is ${userAcctBalance}");
                }

                // Account Balance Update
                else if (transactionOption == 4)
                {
                    userAcctBalance = (userAcctBalance - 0.75);
                    Console.WriteLine("You chose account balance update.");
                    Console.WriteLine($"Your account balance is ${userAcctBalance}");
                }

                // Invalid Input
                else
                {
                    userAcctBalance = (userAcctBalance - 0.75);
                    Console.WriteLine("That is not a valid transaction option.");
                    Console.WriteLine("Your account will be deducted the ATM fee of $0.75.");
                    Console.WriteLine($"Your new balance is {userAcctBalance}");
                }
            }
            else if (userAcctBalance < 0.75)
            {
                Console.WriteLine("I'm sorry, but your account balance is lower than our ATM"
                    + " transaction fee of $0.75, therefore you will not be permitted to use this machine."
                    + " We apologize for the inconvenience, enjoy the rest of your day.");
            }
        }

        public static void ParkingGarageCost()
        {
            double userParkTimeHours, userParkTimeMinutes, parkingFee;
            Console.WriteLine("Welcome to Sam's Parking Garage");
            Console.WriteLine("How long (in minutes) were you parked with us?");
            userParkTimeMinutes = Convert.ToDouble(Console.ReadLine());

            userParkTimeHours = Math.Round(userParkTimeMinutes / 60, 2);

            if (userParkTimeHours >= 0.01 && userParkTimeHours <= 1)
            {
                parkingFee = 4;

                Console.WriteLine($"You were parked for {userParkTimeHours} and you will be charged ${parkingFee}");
            }
            else if (userParkTimeHours >= 1.01 && userParkTimeHours <= 9)
            {
                parkingFee = 4 + (userParkTimeHours * 2);
                parkingFee = Math.Round(parkingFee, 0);
                Console.WriteLine($"You were parked for {userParkTimeHours} hour and you will be charged ${parkingFee}");
            }
            else if (userParkTimeHours > 9)
            {
                parkingFee = 20;
                Console.WriteLine($"You were parked for {userParkTimeHours} and you will be charged ${parkingFee}");
            }
        }

        public static void Hurricane()
        {
            int userHurricaneCategory = 0;
            Console.WriteLine("Choose a category of hurricane (from 1 - 5) and I will tell you the wind speed of that category: ");
            userHurricaneCategory = Convert.ToInt32(Console.ReadLine());

            switch (userHurricaneCategory)
            {
                case 1:
                    Console.WriteLine("Category 1: 74 - 95 mph or 64 - 82 kts or 119 - 153 kmh");
                    break;

                case 2:
                    Console.WriteLine("Category 2: 96 - 110 mph or 83 - 95 kts or 154 - 177 kmh");
                    break;

                case 3:
                    Console.WriteLine("Category 3: 111 - 130 mph or 96 - 113 kts or 178 - 209 kmh");
                    break;

                case 4:
                    Console.WriteLine("Category 4: 131 - 155 mph or 114 - 135 kts or 210 - 249 kmh");
                    break;

                case 5:
                    Console.WriteLine("Category 5: > 155 mph or > 135 kts or > 249 kmh");
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            bool done = false;
            while (!done)
            {
                int userProgramChoice;
                Console.WriteLine("Hello, here are 3 choices of programs you can run.");
                Console.WriteLine("Your options are:");
                Console.WriteLine("1. Simple Banking Machine");
                Console.WriteLine("2. Parking Garage Cost");
                Console.WriteLine("3. Hurricane");
                Console.WriteLine("4. Quit");
                Console.Write("Please type the number associated with the program you would like to run: ");
                userProgramChoice = Convert.ToInt32(Console.ReadLine());

                if (userProgramChoice == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    SimpleBankingMachine();
                }
                else if (userProgramChoice == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    ParkingGarageCost();
                }
                else if (userProgramChoice == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Hurricane();
                }
                else if (userProgramChoice == 4)
                {
                    done = true;
                }
            }
        }
    }
}