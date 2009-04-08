
#region ================== Copyright (c) 2007 Pascal vd Heiden

/*
 * Copyright (c) 2007 Pascal vd Heiden, www.codeimp.com
 * This program is released under GNU General Public License
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 */

#endregion

#region ================== Namespaces

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.IO;
using CodeImp.DoomBuilder.Map;
using System.Reflection;
using System.Diagnostics;

#endregion

namespace CodeImp.DoomBuilder.IO
{
	public interface IMapSetIO
	{
		int MaxSidedefs { get; }
		int VertexDecimals { get; }
		string DecimalsFormat { get; }
		int MaxVertices { get; }
		int MaxLinedefs { get; }
		int MaxSectors { get; }
		int MaxThings { get; }
		int MinTextureOffset { get; }
		int MaxTextureOffset { get; }
		bool HasLinedefTag { get; }
		bool HasThingTag { get; }
		bool HasThingAction { get; }
		bool HasCustomFields { get; }
		bool HasThingHeight { get; }
		bool HasActionArgs { get; }
		bool HasMixedActivations { get; }
		bool HasPresetActivations { get; }
		int HighestTag { get; }
		int HighestAction { get; }
		int HighestEffect { get; }
		int HighestBrightness { get; }
		int HighestThingType { get; }
		double MaxCoordinate { get; }
		double MinCoordinate { get; }
	}
}
