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
            public decimal balance { get; set; }
            public decimal interest { get; set; }
            //
            public BankAccount(decimal startBalance = 10_000, decimal interest = 0.01m)
            {
                balance = startBalance;
                this.interest = interest;
            }
            public abstract void MonthlyInterest();
            public abstract void Update(Form1 formReference);
            public string Balance()
            {
                return $"Balance: {balance:#.##}Kč";
            }
        }
        public class SavingsAccount : BankAccount 
        { 
            public SavingsAccount(decimal startBalance, decimal interest) : base(startBalance, interest)
            {
            
            }
            public override void MonthlyInterest()
            {
                balance += balance * interest;
            }
            public override void Update(Form1 formReference)
            {
                formReference.savingsAccountBalanceLabel.Text = Balance(); 
            }
        }
        public class StudentsSavingsAccount : SavingsAccount
        {
            public StudentsSavingsAccount(decimal startBalance, decimal interest) : base(startBalance, interest)
            {

            }
            public override void Update(Form1 formReference)
            {
                formReference.studentsSavingsAccountBalanceLabel.Text = Balance();
            }
        }
        public class CreditAccount : BankAccount
        {
            public CreditAccount(decimal startBalance, decimal interest) : base(startBalance, interest)
            {

            }
            public override void MonthlyInterest()
            {
                balance += balance * interest;
            }
            public override void Update(Form1 formReference)
            {
                formReference.creditAccountBalanceLabel.Text = Balance();
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

            BankAccount[] accounts = new BankAccount[3]
            {
                new SavingsAccount(startBalance: 10_000, 0.01m),
                new StudentsSavingsAccount(startBalance: 5_000, 0.01m),
                new CreditAccount(startBalance: 10_000, 0.01m)
            };
            simulator = new BankSimulator(accounts);



            dayTimer_Tick(null, null);

        }
        class BankSimulator
        {
            private BankAccount[] accounts;
            public BankSimulator(BankAccount[] accounts)
            {
                this.accounts = accounts;
            }
            public void MonthlyInterest()
            {
                foreach (BankAccount acc in this.accounts)
                {
                    acc.MonthlyInterest();
                }
            }
            public void Update(Form1 formReference)
            {
                foreach (BankAccount acc in this.accounts)
                {
                    acc.Update(formReference);
                }
            }
        }
        private void dayTimer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = $"Day: {date.Day}. {date.Month} {date.Year}";

            simulator.Update(this);

            if(date.Day == 1)
            {
                simulator.MonthlyInterest();
            }

            date = date.AddDays(1);
        }
    }
}
