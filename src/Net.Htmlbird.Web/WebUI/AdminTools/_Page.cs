﻿// ===============================================================================
//  产品名称：网鸟电子商务管理系统(Htmlbird ECMS)
//  产品作者：YMind Chan
//  版权所有：网鸟IT技术论坛 颜铭工作室
// ===============================================================================
//  Copyright © Htmlbird.Net. All rights reserved .
//  官方网站：http://www.htmlbird.net/
//  技术论坛：http://bbs.htmlbird.net/
// ===============================================================================
namespace Net.Htmlbird.Framework.Web.WebUI.AdminTools
{
	public class _Page : _Page<_PageArgs>
	{
		public override bool NeedAuthorise { get { return false; } }

		public override bool NeedPageNavigation { get { return false; } }
	}
}