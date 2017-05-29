//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:		Text Analysis
//	File Name:	DistinctWord.cs
//	Description:	This class ulitizes IComparable and IEquatable to give the DistinctWord objects properties to
//                  compare them and see how they are equal.
//	Author:		Clayton Feathers
//	Created:		Thursday, February 9, 2017
//	Copyright:	Clayton Feathers, 2017
//
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    /// <summary>
    /// This class ulitizes IComparable and IEquatable to give the DistinctWord objects properties to compare them and see how they are equal.
    /// </summary>
    /// <seealso cref="System.IComparable{Project1.DistinctWord}" />
    /// <seealso cref="System.IEquatable{Project1.DistinctWord}" />
    class DistinctWord : IComparable<DistinctWord>, IEquatable<DistinctWord>
    {
        /// <summary>
        /// Gets the word.
        /// </summary>
        /// <value>
        /// The word.
        /// </value>
        public string word { get; private set; }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public int count { get; private set; }

        //Text file used to search for the word count
        private Text txt = null;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DistinctWord"/> class.
        /// </summary>
        public DistinctWord()
        {
            //set word to be nothing and count to be 0
            word = "";
            count = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistinctWord" /> class.
        /// </summary>
        /// <param name="distinctWord">A distinct word to be processed</param>
        public DistinctWord(string distinctWord, Text textFile)
        {
            //set word to the lowercase version of the string parameter
            word = distinctWord.ToLower();

            //text file used
            this.txt = textFile;

            //set count to how often the word is used in the text
            count = SearchForWord(distinctWord);



        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// Searches for how often a word is used in the text file.
        /// </summary>
        /// <param name="distinctWord">The distinct word.</param>
        /// <returns>If no words: 0; If words: however many match</returns>
        private int SearchForWord(string distinctWord)
        {
            int numFound = 0;

            //for ever token in the text file
            for(int i = 0; i<txt.tokenText.Count; i++)
            {
                //if the lower case word equals the lowercase token
                if(distinctWord.ToLower().Equals(txt.tokenText[i].ToLower()))
                {
                    //increment numFound by 1
                    numFound++;
                }

            }

            return numFound;
        }
        #endregion

        #region ToString
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            string content = "";

            //set content to equal the formatted display
            content = string.Format("{0,-20}  {1,-10}", this.word, this.count);

            return content;
        }
        #endregion

        #region IComparable<DistinctWord>
        /// <summary>
        /// Compares the current object with another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return value has the following meanings: Value Meaning Less than zero This object is less than the <paramref name="other" /> parameter.Zero This object is equal to <paramref name="other" />. Greater than zero This object is greater than <paramref name="other" />.
        /// </returns>
        public int CompareTo(DistinctWord other)
        {
            return this.word.CompareTo(other.word);
        }
        #endregion

        #region IEquatable<DistinctWord>
        /// <summary>
        /// Indicates whether the current object is equal to another object of the same type.
        /// </summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        /// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
        /// </returns>
        public bool Equals(DistinctWord other)
        {
            return this.word.Equals(other.word);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        /// <exception cref="ArgumentException"></exception>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return base.Equals(obj);

            if (!(obj is DistinctWord))
                throw new ArgumentException($"Cannot compare a DistinctWord object to a {obj.GetType()} object");
            return Equals(obj as DistinctWord);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            return this.word.GetHashCode();
        }
        #endregion
    }
}
