using System.Threading;
using System.Threading.Tasks;

namespace Demo.TestDataBuilders.Core.Account
{
  public class Account
  {
    private readonly AccountDto _dto;
    private readonly IFetchAccountBalance _fetchAccountBalance;
    private readonly IMarkAccountForFraudCheck _markAccountForFraudCheck;

    public Account(
      AccountDto dto,
      IFetchAccountBalance fetchAccountBalance,
      IMarkAccountForFraudCheck markAccountForFraudCheck)
    {
      _dto = dto;
      _fetchAccountBalance = fetchAccountBalance;
      _markAccountForFraudCheck = markAccountForFraudCheck;
    }

    public async Task MonthEndBilling(CancellationToken token = default)
    {
      _dto.Balance = await _fetchAccountBalance.GetLatestBalance(_dto.Id, token);

      if (_dto.Balance == 123.45m)
      {
        await _markAccountForFraudCheck.Execute(_dto.Id, token);
      }
    }
  }
}