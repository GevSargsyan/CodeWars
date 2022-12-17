using System;

namespace dataplay
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string qu = @"INSERT INTO [universe].[ExcelDatasetCell] 
                            ([PresentationID], [DatasetID], [VariableID], [DatasetCellName], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate])
                          VALUES
                            (@PresentationID, @DatasetID, @VariableID, @DatasetCellName, 0, @CreatedBy, GETUTCDATE(), @CreatedBy, GETUTCDATE())";


            for (int i = 0; i < 3; i++)
            {
                qu += ",(@PresentationID, @DatasetID, @VariableID, @DatasetCellName, 0, @CreatedBy, GETUTCDATE(), @CreatedBy, GETUTCDATE())";

            }

            Console.WriteLine(qu);

        }
    }
}
