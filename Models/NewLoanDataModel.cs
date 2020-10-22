using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace cfLoanCalcWasm.Models
{
  public class NewLoanDataModel
  {
    public double LoanInterestRate { get; set; }
    public double LoanTermLength { get; set; }
    public double ProposedAddAExtra { get; set; } = 0;
    public double LoanAmount { get; set; }
    public double ProposedLoanInterestRate { get; set; }
    public double ProposedLoanTermLength { get; set; }
    public double ProposedLoanAmount { get; set; }
    public List<MonthData> LoanSchedule { get; set; }
    public List<MonthData> ProposedSchedule { get; set; }
  }
    public class MonthData
    {
      public int paymentNumber { get; set; }
      public double paymentAMT { get; set; }
      public double interestAMT { get; set; }
      public double principalAMT { get; set; }
      public double loanBalance { get; set; }
      public double interestTotal { get; set; }
    }
}