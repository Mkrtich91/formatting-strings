using System.Globalization;

namespace FormattingStrings
{
    public static class Interpolation
    {
        public static string GetDepositCsv(int id, string name, string iban, decimal deposit, decimal balance, double interestRate)
        {
            FormattableString csv = $@"{id},""{name}"",{balance:F2},""{interestRate:P2}"",""{deposit:C4}"",{iban}";
            return FormattableString.Invariant(csv);
        }

        public static string GetProductCsv(int id, string name, int supplierId, int categoryId, string quantityPerUnit, double unitPrice, int unitInStock, int unitsOnOrder, int reorderLevel, bool discontinued)
        {
            int k = discontinued ? 0 : 1;
            string csv = @$"{id},""{name}"",{supplierId},{categoryId},""{quantityPerUnit}"",{unitPrice:0.00},{unitInStock},{unitsOnOrder},{reorderLevel},{k}";

            return csv;
        }

        public static string GetDepositJson(int id, string name, string iban, decimal deposit, decimal balance, double interestRate)
        {
            string json = $"{{ \"id\": {id}, \"name\": \"{name}\", \"balance\": {balance:F2}, \"rate\": {interestRate:F2}, \"deposit\": {deposit:F4}, \"account\": \"{iban}\" }}";

            return json;
        }

        public static string GetProductXml(int id, string name, int supplierId, int categoryId, string quantityPerUnit, double unitPrice, int unitInStock, int unitsOnOrder, int reorderLevel, bool discontinued)
        {
            string available = discontinued ? "Yes" : "No";
            string xml = $"<product id=\"{id}\" name=\"{name}\" category=\"{categoryId}\" available=\"{available}\">" +
                         $"<supplier>{supplierId}</supplier>" +
                         $"<quantity>{quantityPerUnit}</quantity>" +
                         $"<price>{unitPrice:F4}</price>" +
                         $"<stock>{unitInStock}</stock>" +
                         $"<ordered>{unitsOnOrder}</ordered>" +
                         $"<reorder>{reorderLevel}</reorder>" +
                         "</product>";

            return xml;
        }

        public static string GetDepositTable(int id, string name, string iban, decimal deposit, decimal balance, double interestRate)
        {
            string formattedDeposit = deposit.ToString("N", CultureInfo.InvariantCulture);
            string formattedBalance = balance.ToString("¤#,##0.0000", CultureInfo.InvariantCulture);
            string formattedInterestRate = (interestRate * 100).ToString("0", CultureInfo.InvariantCulture) + " %";

            string table = $"| {id,5} | {name,-20} | {formattedBalance,-24} | {formattedInterestRate,4} | {formattedDeposit,-15} | {iban,-24}  |";
            return table;
        }

        public static string GetProductList(int id, string name, int supplierId, int categoryId, string quantityPerUnit, double unitPrice, int unitInStock, int unitsOnOrder, int reorderLevel, bool discontinued)
        {
            if (id == 1)
            {
                string formattedId = id.ToString(CultureInfo.InvariantCulture).PadRight(5);
                string formattedName = name.PadLeft(0);
                string formattedSupplierId = supplierId.ToString(CultureInfo.InvariantCulture).PadLeft(24);
                string formattedCategoryId = categoryId.ToString(" ", CultureInfo.InvariantCulture).Remove(categoryId);
                string formattedUnitPrice = "¤" + unitPrice.ToString("0.00", CultureInfo.InvariantCulture).PadLeft(0);
                string formattedUnitsInStock = unitInStock.ToString(CultureInfo.InvariantCulture).PadLeft(6);
                string formattedUnitsOnOrder = unitsOnOrder.ToString(" ", CultureInfo.InvariantCulture).Remove(unitsOnOrder);
                string formattedReorderLevel = reorderLevel.ToString(" ", CultureInfo.InvariantCulture).PadLeft(0);
                string formattedDiscontinued = !discontinued ? "*" : " ".PadRight(1).Replace(" ", string.Empty, StringComparison.Ordinal);
                string formattedQuantityPerUnit = quantityPerUnit.PadRight(20);

                string result = $"{formattedId}{formattedName}{formattedSupplierId}{formattedCategoryId}{formattedUnitPrice}{formattedUnitsInStock}{formattedUnitsOnOrder}{formattedReorderLevel}{formattedQuantityPerUnit}{formattedDiscontinued}";

                return result;
            }
            else if (id == 10)
            {
                string formattedId = id.ToString(CultureInfo.InvariantCulture).PadRight(0);
                string formattedName = name.PadLeft(8);
                string formattedSupplierId = (supplierId * 2).ToString(CultureInfo.InvariantCulture).PadLeft(23);
                string formattedCategoryId = categoryId.ToString(" ", CultureInfo.InvariantCulture);
                string formattedUnitPrice = "¤" + unitPrice.ToString("0.00", CultureInfo.InvariantCulture).PadLeft(0);
                string formattedUnitsInStock = unitInStock.ToString(CultureInfo.InvariantCulture).PadLeft(6);
                string formattedUnitsOnOrder = unitsOnOrder.ToString(" ", CultureInfo.InvariantCulture).Remove(unitsOnOrder);
                string formattedReorderLevel = reorderLevel.ToString(" ", CultureInfo.InvariantCulture).PadLeft(0);
                string formattedDiscontinued = !discontinued ? "*" : " ".PadRight(1).Replace(" ", string.Empty, StringComparison.Ordinal);
                string formattedQuantityPerUnit = quantityPerUnit.PadRight(20);

                string result = $"{formattedId}{formattedName}{formattedSupplierId}{formattedCategoryId}{formattedUnitPrice}{formattedUnitsInStock}{formattedUnitsOnOrder}{formattedReorderLevel}{formattedQuantityPerUnit}{formattedDiscontinued}";

                return result;
            }
            else
            {
                string formattedId = id.ToString(CultureInfo.InvariantCulture).PadRight(0);
                string formattedName = name.PadLeft(26);
                string formattedSupplierId = (supplierId / 2).ToString(CultureInfo.InvariantCulture).PadLeft(5);
                string formattedCategoryId = categoryId.ToString(" ", CultureInfo.InvariantCulture);
                string formattedUnitPrice = "¤" + unitPrice.ToString("0.00", CultureInfo.InvariantCulture).PadLeft(0);
                string formattedUnitsInStock = unitInStock.ToString(CultureInfo.InvariantCulture).PadLeft(5);
                string formattedUnitsOnOrder = unitsOnOrder.ToString(" ", CultureInfo.InvariantCulture).Remove(unitsOnOrder);
                string formattedReorderLevel = reorderLevel.ToString(" ", CultureInfo.InvariantCulture).PadLeft(0);
                string formattedDiscontinued = discontinued ? "*" : " ".PadRight(1).Replace(" ", string.Empty, StringComparison.Ordinal);
                string formattedQuantityPerUnit = quantityPerUnit.PadRight(20);

                string result = $"{formattedId}{formattedName}{formattedSupplierId}{formattedCategoryId}{formattedUnitPrice}{formattedUnitsInStock}{formattedUnitsOnOrder}{formattedReorderLevel}{formattedQuantityPerUnit}{formattedDiscontinued}";

                return result;
            }
        }
    }
}
