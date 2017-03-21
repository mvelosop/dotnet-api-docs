' The following code example compares two strings using the different CompareInfo instances:
'    a CompareInfo instance associated with the "Spanish - Spain" culture with international sort,
'    a CompareInfo instance associated with the "Spanish - Spain" culture with traditional sort, and
'    a CompareInfo instance associated with the InvariantCulture.

Imports System
Imports System.Globalization

Public Class SamplesCompareInfo

   Public Shared Sub Main()

      ' Defines the strings to compare.
      Dim myStr1 As [String] = "calle"
      Dim myStr2 As [String] = "calor"

      ' Uses GetCompareInfo to create the CompareInfo that uses the "es-ES" culture with international sort.
      Dim myCompIntl As CompareInfo = CompareInfo.GetCompareInfo("es-ES")

      ' Uses GetCompareInfo to create the CompareInfo that uses the "es-ES" culture with traditional sort.
      Dim myCompTrad As CompareInfo = CompareInfo.GetCompareInfo(&H40A)

      ' Uses the CompareInfo property of the InvariantCulture.
      Dim myCompInva As CompareInfo = CultureInfo.InvariantCulture.CompareInfo

      ' Compares two strings using myCompIntl.
      Console.WriteLine("Comparing ""{0}"" and ""{1}""", myStr1, myStr2)
      Console.WriteLine("   With myCompIntl.Compare: {0}", myCompIntl.Compare(myStr1, myStr2))
      Console.WriteLine("   With myCompTrad.Compare: {0}", myCompTrad.Compare(myStr1, myStr2))
      Console.WriteLine("   With myCompInva.Compare: {0}", myCompInva.Compare(myStr1, myStr2))

   End Sub 'Main 

End Class 'SamplesCompareInfo


'This code produces the following output.
'
'Comparing "calle" and "calor"
'   With myCompIntl.Compare: -1
'   With myCompTrad.Compare: 1
'   With myCompInva.Compare: -1