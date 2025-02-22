﻿namespace SuggestBoxTestLib.ViewModels
{
    using SuggestBoxLib.Interfaces;
    using SuggestBoxLib.SuggestSource;
    using System.Threading.Tasks;

    /// <summary>
    /// Defines a suggestion object to generate suggestions
    /// based on sub entries of specified string.
    /// </summary>
    public class DummySuggestSource : ISuggestSource
    {
        /// <summary>
        /// Method returns a task that returns a list of suggestion objects
        /// that are associated to the <paramref name="input"/> string
        /// and given <paramref name="location"/> object.
        /// 
        /// This sample is really easy because it simply takes the input
        /// string and add an output as suggestion to the given input.
        /// 
        /// This always returns 2 suggestions.
        /// </summary>
        /// <param name="location"></param>
        /// <param name="input"></param>
        /// <returns></returns>
        public Task<ISuggestResult> SuggestAsync(object location,
                                                string input)
        {
            var result = new SuggestResult();

            // returns a collection of anynymous objects
            // each with a Header and Value property
            result.Suggestions.Add(new { Header = input + "-add xyz", Value = input + "xyz" });
            result.Suggestions.Add(new { Header = input + "-add abc", Value = input + "abc" });

            return Task.FromResult<ISuggestResult> (result);
        }
    }
}
