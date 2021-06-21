using System;

namespace Demo.TestDataBuilders.Core.Account
{
  public class AccountDto
  {
    public Guid Id { get; set; }
    public Guid AccountHolderId { get; set; }
    public decimal Balance { get; set; }
  }
}