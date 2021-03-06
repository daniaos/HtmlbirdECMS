// ===============================================================================
//  产品名称：网鸟电子商务管理系统(Htmlbird ECMS)
//  产品作者：YMind Chan
//  版权所有：网鸟IT技术论坛 颜铭工作室
// ===============================================================================
//  Copyright © Htmlbird.Net. All rights reserved .
//  官方网站：http://www.htmlbird.net/
//  技术论坛：http://bbs.htmlbird.net/
// ===============================================================================
namespace Net.Htmlbird.Framework.Web.Paging
{
	/// <summary>
	/// 表示构造翻页链接时需要的参数。
	/// </summary>
	public struct PaginationArgs
	{
		/// <summary>
		/// 初始化 <see cref="PaginationArgs"/> 类的新实例。
		/// </summary>
		/// <param name="totalItemCount">包含翻页链接所关联的数据的全部项数的数字。</param>
		/// <param name="totalPageCount">包含翻页链接所关联的数据的全部页数的数字。</param>
		/// <param name="currentPageIndex">包含翻页链接描述当前页次的索引数字。</param>
		/// <param name="visibleLinkCount">包含翻页链接高亮按钮前后附加按钮的最大个数的数字。</param>
		public PaginationArgs(int totalItemCount, int totalPageCount, int currentPageIndex, int visibleLinkCount) : this()
		{
			this.TotalItemCount = totalItemCount;
			this.TotalPageCount = totalPageCount;
			this.CurrentPageIndex = currentPageIndex == 0 ? 1 : currentPageIndex;
			this.VisibleLinkCount = visibleLinkCount == 0 ? 5 : visibleLinkCount;
		}

		/// <summary>
		/// 获取或设置包含翻页链接所关联的数据的全部项数的数字。
		/// </summary>
		public int TotalItemCount { get; set; }

		/// <summary>包含翻页链接所关联的数据的全部页数的数字。
		/// 获取或设置
		/// </summary>
		public int TotalPageCount { get; set; }

		/// <summary>
		/// 获取或设置包含翻页链接描述当前页次的索引数字。
		/// </summary>
		public int CurrentPageIndex { get; set; }

		/// <summary>
		/// 获取或设置包含翻页链接高亮按钮前后附加按钮的最大个数的数字。
		/// </summary>
		public int VisibleLinkCount { get; set; }
	}
}