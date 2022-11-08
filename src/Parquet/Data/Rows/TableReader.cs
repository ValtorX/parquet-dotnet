using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parquet.Data.Rows
{
   /// <summary>
   /// Navigates the table
   /// </summary>
   public sealed class TableReader
   {
      private readonly Table _table;

      /// <summary>
      /// 
      /// </summary>
      public TableReader(Table table)
      {
         _table = table;
      }
   }
}
