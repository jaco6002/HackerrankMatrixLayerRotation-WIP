using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace ClassLibrary1
{
    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        static void matrixRotation(List<List<int>> matrix, int r)
        {
            List<List<int>> matrixout = matrix;
            for (int i = 0; i < matrix.Count; i++)
            {
                if (i==0)
                {
                    for (int l = 0; l < matrix[i].Count; l++)
                    {
                        
                        if (l == matrix[i].Count-1)
                        {
                            matrixout[i][i] = matrix[i + 1][matrix[i].Count - 1];
                        }
                        else
                        {
                            matrixout[i][l] = matrix[i][l + 1];
                        }
                        
                    }
                }

                if (i==matrix.Count-1)
                {
                    for (int l = 0; l < matrix[i].Count; l++)
                    {
                        if (l==0)
                        {
                            matrixout[i][l] = matrix[i-1][l];
                        }
                        else
                        {
                            matrixout[i][l] = matrix[i][l - 1];
                        }
                    }
                }
                else
                {
                    
                }
               
            }

            matrix = matrixout;
        }

    }
}
