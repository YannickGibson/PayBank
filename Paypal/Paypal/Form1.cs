﻿using System;
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
            //
            public BankAccount(decimal startBalance = 10_000)
            {
                balance = startBalance;
            }
        }
        public class SavingsAccount : BankAccount 
        { 
            public SavingsAccount() : base()
            {
    
            }
        }
        public class StudentsSavingsAccount : SavingsAccount
        {
            public StudentsSavingsAccount() : base()
            {

            }
        }
        public class CreditAccount : BankAccount
        {
            public CreditAccount() : base()
            {

            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        DateTime date;
        private void Form1_Load(object sender, EventArgs e)
        {
            date = DateTime.Now;
        }

        private void dayTimer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = $"Day: {date.Day}. {date.Month} {date.Year}";
            if(date.Day == 1)
            {

            }
        }
    }
}
