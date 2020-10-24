using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paypal
{
    public partial class Form1 : Form
    {
        /*
Příklad pro dvojčlenné skupiny:
Vytvořte konzolový nebo WPF program, který bude simulovat funkce banky.
Banka vede svým klientům účty, které jsou buď depozitní (spořicí) nebo kreditní (úvěrové).

Na spořicí účty klienti vkládají své peníze za účelem zhodnocení(to je vyjádřené úrokovou sazbou spořicího účtu) a mohou z nich vybírat, jen pokud je jejich zůstatek kladný.
Spořicí účet může mít svou variantu pro studenty. Ten má omezenou velikost jednorázového výběru, jinak se chová stejně, jako obyčejný spořicí účet.
Úroky z vkladů banka svým klientům připisuje na konci měsíce.
Z úvěrových účtů mohou klienti vybírat peníze do výše úvěrového rámce a s úročením, které určí banka (tedy mohou jít "do mínusu"). Vkládáním peněz na úvěrový účet splácí svůj dluh(jistinu a úroky) bance.

Na všechny účty je možné vkládat a vybírat z nich, pokud to aktuální stav účtu nebo úvěrový limit dovoluje.

Navrhněte třídy pro depozitní, studentský a úvěrový účet. Atributy tříd implementujte jako vlastnosti, rozvažte jejich dostupnost z ostatních tříd.
Některé funkce(např. připisování úroků na konci měsíce) jsou závislé na čase. Navrhněte mechanismus pro testování těchto funkcí.

V metodě Main() vytvořte instance depozitních, úvěrových a studentských účtů. Vytvořte pole těchto účtů, proveďte na nich vklady a výběry a nakonec vypište aktuální stav těchto účtů.
Vytvořte projekt, který bude zahrnovat simulátor banky.
Promyslete si dělbu práce na projektu a vytvořte dokument, který bude fungovat jako pracovní plán projektu. Buďte připraveni na jeho změny, dokument verzujte společně se zdrojovým kódem.
Projekt verzujte na GitHubu a dohodněte se ve skupině, kdo bude za společné úložiště zodpovědný jako administrátor. 
Nastudujte si principy spolupráce v GitHubu a spolupráci na společné repository si nejdříve vyzkoušejte na cvičném projektu.
        */
        public abstract class BankAccount
        {
            internal decimal balance { get; set; }
            internal decimal interest { get; set; } = 0.005m;
            //
            public BankAccount(decimal startBalance = 10_000)
            {
                balance = startBalance;
            }
            public abstract void MonthlyInterest(Form1 that);
            public string Balance()
            {
                return $"Balance: {balance:#.##} Kč";
            }
            public void Withdraw(int amount)
            {
                balance -= amount;
            }
            public void Deposit(int amount)
            {
                balance += amount;
            }
            public virtual bool CheckWithdraw(decimal amount)
            {
                if (balance - amount > 0)
                    return true;
                else
                    return false;
            }
        }
        public class SavingsAccount : BankAccount 
        {
            public SavingsAccount(decimal startBalance) : base(startBalance)
            {
                interest = 0.01m;
            }
            public override void MonthlyInterest(Form1 that)
            {
                decimal monthlyInterest = balance * interest;
                balance += monthlyInterest;
                that.savingsAccountMonthlyInterest.Text = $"+ {monthlyInterest:#.##} Kč";
            }
        }
        public class StudentSavingsAccount : SavingsAccount
        {
            public StudentSavingsAccount(decimal startBalance) : base(startBalance)
            {

            }
            public override void MonthlyInterest(Form1 that)
            {
                decimal monthlyInterest = balance * interest;
                balance += monthlyInterest;
                that.studentSavingsAccountMonthlyInterest.Text = $"+ {monthlyInterest:#.##} Kč";
            }
        }
        public class CreditAccount : BankAccount
        {
            public CreditAccount(decimal startBalance) : base(startBalance)
            {

            }
            int negative = 5_000;
            decimal baseTax = 15;
            public override void MonthlyInterest(Form1 that)
            {
                decimal interestAndTax = 0;
                if ( balance > 0){
                    interestAndTax += balance * interest;
                    interestAndTax += baseTax;
                }
                else if (balance > -negative)
                {
                    // rate of pain is going to decline
                    interestAndTax += (negative - balance) * interest;
                    interestAndTax += baseTax;
                }
                else
                {
                    balance = negative; //interestAndTag still gon be 0
                }
                that.creditAccountMonthlyInterest.Text = $"- {interestAndTax:#.##} Kč";
                balance -= interestAndTax;
            }
            public override bool CheckWithdraw(decimal amount)
            {
                if (balance + negative - amount > 0)
                    return true;
                else
                    return false;
            }
        }




        public Form1()
        {
            InitializeComponent();
        }
        DateTime date;
        BankSimulator simulator;
        private void Form1_Load(object sender, EventArgs e)
        {
            date = DateTime.Now.Date;

            SavingsAccount sav = new SavingsAccount(startBalance: 10_000);
            savingsAccountDepositButton.Tag = new object[2] { sav, savingsAccountDepositNumericUpDown };
            savingsAccountWithdrawButton.Tag = new object[2] { sav, savingsAccountWithdrawNumericUpDown };

            StudentSavingsAccount studSav = new StudentSavingsAccount(startBalance: 5_000);
            studentSavingsAccountDepositButton.Tag = new object[2] { studSav, studentSavingsAccountDepositNumericUpDown };
            studentSavingsAccountWithdrawButton.Tag = new object[2] { studSav, studentSavingsAccountWithdrawNumericUpDown };

            CreditAccount cred = new CreditAccount(startBalance: 10_000);
            creditAccountDepositButton.Tag = new object[2] { cred, creditAccountDepositNumericUpDown };
            creditAccountWithdrawButton.Tag = new object[2] { cred, creditAccountWithdrawNumericUpDown };

            simulator = new BankSimulator(
                sav,
                studSav,
                cred
                );


            dayTimer_Tick(null, null);
        }
        class BankSimulator
        {
            private BankAccount[] accounts;
            public SavingsAccount savingsAccount;
            public StudentSavingsAccount studentSavingsAccount;
            public CreditAccount creditAccount;
            public BankSimulator(
                SavingsAccount savingsAccount,
                StudentSavingsAccount studentSavingsAccount,
                CreditAccount creditAccount
                )
            {
                this.savingsAccount = savingsAccount;
                this.studentSavingsAccount = studentSavingsAccount;
                this.creditAccount = creditAccount;
                accounts = new BankAccount[3]
                {
                    savingsAccount, studentSavingsAccount, creditAccount
                };
            }
            public void MonthlyInterest(Form1 that)
            {
                foreach (BankAccount acc in this.accounts)
                {
                    acc.MonthlyInterest(that);
                }
            }
            public void Deposit(BankAccount acc, int amount)
            {
                acc.Deposit(amount);
            }
            public void Update(Form1 that)
            {
                that.savingsAccountBalanceLabel.Text = savingsAccount.Balance();
                that.studentSavingsAccountBalanceLabel.Text = studentSavingsAccount.Balance();
                that.creditAccountBalanceLabel.Text = creditAccount.Balance();
            }
        }
        private void dayTimer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = $"Day: {date.Day}. {date.Month} {date.Year}";

            simulator.Update(this);

            if(date.Day == 1)
            {
                simulator.MonthlyInterest(this);
                ActivateDeactivateWitdrawButtons();//Only necessary after the balance changes
            }

            date = date.AddDays(1);
        }

        private void stopTimeButton_Click(object sender, EventArgs e)
        {
            dayTimer.Enabled = !dayTimer.Enabled;
        }

        private void savingsAccountDepositButton_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            object[] account_numericUpDown = b.Tag as object[];
            BankAccount targetAccount =  account_numericUpDown[0] as BankAccount;
            int amount = Convert.ToInt32( (account_numericUpDown[1] as NumericUpDown).Value );
            simulator.Deposit(targetAccount, amount);

            if (targetAccount.CheckWithdraw(amount) == true)
            {
                b.Enabled = true;
            }
            simulator.Update(this);
        }

        private void savingsAccountWithdrawButton_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            object[] account_numericUpDown = b.Tag as object[];
            BankAccount targetAccount = account_numericUpDown[0] as BankAccount;
            int amount = Convert.ToInt32( (account_numericUpDown[1] as NumericUpDown).Value );
            targetAccount.Withdraw(amount);

            if ( targetAccount.CheckWithdraw(amount) == false)
            {
                b.Enabled = false;
            }
            simulator.Update(this);
        }

        void ActivateDeactivateWitdrawButtons()
        {
            if (simulator.savingsAccount.CheckWithdraw(savingsAccountWithdrawNumericUpDown.Value))
                savingsAccountWithdrawButton.Enabled = true;
            else
                savingsAccountWithdrawButton.Enabled = false;

            if (simulator.studentSavingsAccount.CheckWithdraw(studentSavingsAccountWithdrawNumericUpDown.Value) )
                studentSavingsAccountWithdrawButton.Enabled = true;
            else
                studentSavingsAccountWithdrawButton.Enabled = false;

            if (simulator.creditAccount.CheckWithdraw(creditAccountWithdrawNumericUpDown.Value))
                creditAccountWithdrawButton.Enabled = true;
            else
                creditAccountWithdrawButton.Enabled = false;
        }

        private void savingsAccountDepositNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ActivateDeactivateWitdrawButtons();
        }
    }
}
