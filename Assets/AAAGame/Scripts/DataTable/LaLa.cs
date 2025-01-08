//------------------------------------------------------------
//------------------------------------------------------------
// 此文件由工具自动生成，请勿直接修改。
// 生成时间：__DATA_TABLE_CREATE_TIME__
//------------------------------------------------------------

using GameFramework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityGameFramework.Runtime;

[System.Reflection.Obfuscation(Feature = "renaming", ApplyToMembers = false)]
/// <summary>
/// LaLa
/// </summary>
public class LaLa : DataRowBase
{
	private int m_Id = 0;
	/// <summary>
    /// 学生id
    /// </summary>
    public override int Id
    {
        get { return m_Id; }
    }

        /// <summary>
        /// 请添加字段, 字段名首字母大写
        /// </summary>
        public int Score
        {
            get;
            private set;
        }

        /// <summary>
        /// 
        /// </summary>
        public string Desc
        {
            get;
            private set;
        }

        public override bool ParseDataRow(string dataRowString, object userData)
        {
            string[] columnStrings = dataRowString.Split(DataTableExtension.DataSplitSeparators);
            for (int i = 0; i < columnStrings.Length; i++)
            {
                columnStrings[i] = columnStrings[i].Trim(DataTableExtension.DataTrimSeparators);
            }

            int index = 0;
            index++;
            m_Id = int.Parse(columnStrings[index++]);
            index++;
            Score = int.Parse(columnStrings[index++]);
            Desc = columnStrings[index++];

            return true;
        }

        public override bool ParseDataRow(byte[] dataRowBytes, int startIndex, int length, object userData)
        {
            using (MemoryStream memoryStream = new MemoryStream(dataRowBytes, startIndex, length, false))
            {
                using (BinaryReader binaryReader = new BinaryReader(memoryStream, Encoding.UTF8))
                {
                    m_Id = binaryReader.Read7BitEncodedInt32();
                    Score = binaryReader.Read7BitEncodedInt32();
                    Desc = binaryReader.ReadString();
                }
            }

            return true;
        }

//__DATA_TABLE_PROPERTY_ARRAY__
}
