﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StackDemo
{
    public static class BalancedBrackets
    {
        // Complete the isBalanced function below.
        public static string IsBalanced(string s)
        {
            Stack<char> brackets = new Stack<char>();
            foreach (var c in s)
            {
                if (c.Equals('{') || c.Equals('(') || c.Equals('['))
                    brackets.Push(c);
                else
                {
                    if (brackets.Count <= 0)
                        return "NO";
                    else
                    {
                        char bracketChar = brackets.Pop();
                        if (c == ')' && bracketChar != '(')
                            return "NO";
                        else if (c == ']' && bracketChar != '[')
                            return "NO";
                        else if (c == '}' && bracketChar != '{')
                            return "NO";
                    }
                }
            }
            if (brackets.Count == 0)
                return "YES";
            else
                return "NO";
        }
    }
}
/*
 * A bracket is considered to be any one of the following characters: (, ), {, }, [, or ].

Two brackets are considered to be a matched pair if the an opening bracket (i.e., (, [, or {) occurs to the left of a closing bracket (i.e., ), ], or }) 
of the exact same type. There are three types of matched pairs of brackets: [], {}, and ().

A matching pair of brackets is not balanced if the set of brackets it encloses are not matched. 
For example, {[(])} is not balanced because the contents in between { and } are not balanced.
The pair of square brackets encloses a single, unbalanced opening bracket, (, and the pair of parentheses encloses a single, unbalanced closing square bracket, ].

By this logic, we say a sequence of brackets is balanced if the following conditions are met:

It contains no unmatched brackets.
The subset of brackets enclosed within the confines of a matched pair of brackets is also a matched pair of brackets.
Given n strings of brackets, determine whether each sequence of brackets is balanced. If a string is balanced, return YES. Otherwise, return NO.

Function Description

Complete the function isBalanced in the editor below. It must return a string: YES if the sequence is balanced or NO if it is not.

isBalanced has the following parameter(s):

s: a string of brackets
Input Format

The first line contains a single integer n, the number of strings.
Each of the next n lines contains a single string s, a sequence of brackets.

Output Format

For each string, return YES or NO.

Sample Input
3
{[()]}
{[(])}
{{[[(())]]}}

Sample Output
YES
NO
YES

Explanation
The string {[()]} meets both criteria for being a balanced string, so we print YES on a new line.
The string {[(])} is not balanced because the brackets enclosed by the matched pair { and } are not balanced: [(]).
The string {{[[(())]]}} meets both criteria for being a balanced string, so we print YES on a new line.
 */