using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AudioDevices
{
    /// <summary>
    /// Class for a defiition of an track 
    /// </summary>
    public class Track
    {

        #region Fields
        /// <summary>
        /// The identifier
        /// </summary>
        private int id;
        /// <summary>
        /// The name
        /// </summary>
        private string name;
        /// <summary>
        /// The artist
        /// </summary>
        private string artist;
        /// <summary>
        /// The albumsource
        /// </summary>
        private string albumsource;
        /// <summary>
        /// The length
        /// </summary>
        private Time length;
        /// <summary>
        /// The type
        /// </summary>
        private Category type;
        #endregion

        #region Properties
        /// <summary>
        /// Sets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public Time Length
        {
            set { this.length = value; }
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public Category Type
        {
            get { return type; }
            set { this.type = value; }
        }

        /// <summary>
        /// Gets the display name.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        public string DisplayName
        {
            get
            {
                return this.name != null && this.artist != null ?
                    this.artist + " - " + this.name : "Unknown";
                /*
                if (this.name != null && this.artist != null)
                {
                    return this.artist + " - " + this.name;
                }
                else
                {
                    return "Unknown";
                }
                */
            }
        }

        /// <summary>
        /// Gets the display length.
        /// </summary>
        /// <value>
        /// The display length.
        /// </value>
        public string DisplayLength
        {
            get
            {
                return this.length.ToString();
            }
        }
        #endregion

        #region Constructors
        // Blanco constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Track"/> class.
        /// </summary>
        public Track()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Track"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public Track(int id)
        {
            this.id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Track"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        public Track(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Track"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="artist">The artist.</param>
        public Track(int id, string name, string artist)
        {
            this.id = id;
            this.name = name;
            this.artist = artist;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Gets the length.
        /// </summary>
        /// <returns></returns>
        public Time GetLength()
        {
            return this.length;
        }

        /// <summary>
        /// Gets the length in seconds.
        /// </summary>
        /// <returns></returns>
        public int GetLengthInSeconds()
        {
            return this.length.Seconds;

            //return int.Parse(this.length.ToString().Substring(0, 2)) * 3600 +
            //    int.Parse(this.length.ToString().Substring(3, 2)) * 60 +
            //    int.Parse(this.length.ToString().Substring(6, 2));
        }
        #endregion
    }
}