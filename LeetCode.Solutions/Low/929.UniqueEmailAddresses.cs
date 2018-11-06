using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode.Solutions.Low
{
    //https://leetcode.com/problems/unique-email-addresses
    public class UniqueEmailAddressesSolution
    {
        public int NumUniqueEmails(string[] emails)
        {
            var hashTable = new HashSet<string>();

            for (var i = 0; i < emails.Length; i++)
            {
                for (var j = 0; j < emails[i].Length; j++)
                {
                    if (emails[i][j] == '.')
                    {
                        emails[i] = emails[i].Remove(j, 1);
                        --j;
                    }
                    else if (emails[i][j] == '+')
                    {
                        var removeIndex = j;

                        while (emails[i][j] != '@')
                        {
                            j++;
                        }

                        emails[i] = emails[i].Remove(removeIndex, j - removeIndex);
                        break;
                    }
                    else if (emails[i][j] == '@')
                    {
                        break;
                    }
                }

                hashTable.Add(emails[i]);
            }

            return hashTable.Count;
        }
    }
}