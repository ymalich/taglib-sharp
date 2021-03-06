//
// StartEnd.cs: Provides methods for reading important information from an
// MPEG-4 file.
//
// Author:
//   Yury Malich (yury.malich@gmail.com)
//
// Copyright (C) 2006-2007 Brian Nickel
// 
// This library is free software; you can redistribute it and/or modify
// it  under the terms of the GNU Lesser General Public License version
// 2.1 as published by the Free Software Foundation.
//
// This library is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307
// USA
//

namespace TagLib.Mpeg4
{
	/// <summary>
	/// StartEnd
	/// </summary>
	public struct StartEnd
	{
		/// <summary>
		/// block start
		/// </summary>
		public long StartPosition;

		/// <summary>
		/// reginon end
		/// </summary>
		public long EndPosition;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="start"></param>
		/// <param name="end"></param>
		public StartEnd (long start, long end)
		{
			this.StartPosition = start;
			this.EndPosition = end;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals (object obj) => obj is StartEnd other && StartPosition == other.StartPosition && EndPosition == other.EndPosition;

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode ()
		{
			var hashCode = 1075529825;
			hashCode = hashCode * -1521134295 + StartPosition.GetHashCode ();
			hashCode = hashCode * -1521134295 + EndPosition.GetHashCode ();
			return hashCode;
		}
 	}
}
