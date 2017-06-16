﻿using System;
using System.Collections;
using System.Collections.Generic;

public class SCCreateRoomRet : SocketPacket
{
	protected BYTE mResult = new BYTE();  // 0表示成功,1表示失败
	protected INT mRoomID = new INT();
	public SCCreateRoomRet(PACKET_TYPE type)
		:
		base(type)
	{
		fillParams();
		zeroParams();
	}
	protected override void fillParams()
	{
		pushParam(mResult);
		pushParam(mRoomID);
	}
	public override void execute()
	{
		// 创建房间成功,等待服务器通知进入房间
		if(mResult.mValue == 0)
		{
			;
		}
		else
		{
			UnityUtility.logInfo("创建房间失败!");
		}
	}
}