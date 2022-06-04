namespace MessageContracts;


public interface IInvoiceToCreate
{
    int CustomerNumber { get; }
    List<InvoiceItems> InvoiceItems { get; set; }
}