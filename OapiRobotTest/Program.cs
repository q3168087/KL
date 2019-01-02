﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OapiRobotTest
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1、发送Text消息
            //OapiRobot.OapiRobotText("啦啦啦测试", new List<string> { "180********" }, false);
            #endregion

            #region 2、发送MarkDown消息  MarkDown语法学习可参照以下地址：https://www.jianshu.com/p/191d1e21f7ed 
            //图片地址必须写钉钉可以访问的地址。如果是项目本地地址，只有在项目发布之后，外网可以访问项目域名下的图片情况下，才能够在消息中展示图片，否则不行。
            //如果项目未发布，可采用以下教程，将自己的图片上传百度云，借助百度云生成图片下载的外链：https://jingyan.baidu.com/article/f006222806dfdcfbd3f0c880.html
            //OapiRobot.OapiRobotMarkDown("杭州天气", "#### 杭州天气  \n > 9度，@1825718XXXX 西北风1级，空气良89，相对温度73%\n\n > ![avatar](https://thumbnail0.baidupcs.com/thumbnail/853bee5dadaa5b3b0224d1f7e9b99146?fid=288451525-250528-1091053987687165&time=1546401600&rt=sh&sign=FDTAER-DCb740ccc5511e5e8fedcff06b081203-tbnUIzx8woNY1nRPMu1lXKAiR1o%3D&expires=8h&chkv=0&chkbd=0&chkpc=&dp-logid=35712862995877697&dp-callid=0&size=c710_u400&quality=100&vuk=-&ft=video)\n  > ###### 10点20分发布 [天气](http://www.thinkpage.cn/)", new List<string> { "18086516541" }, false);
            //OapiRobot.OapiRobotMarkDown("杭州天气", "#### 杭州天气  \n > 9度，@1825718XXXX 西北风1级，空气良89，相对温度73%\n\n > ![screenshot](http://i01.lw.aliimg.com/media/lALPBbCc1ZhJGIvNAkzNBLA_1200_588.png)\n  > ###### 10点20分发布 [天气](http://www.thinkpage.cn/)", new List<string> { "180********" }, false);
            #endregion;

            #region 3、发送整体跳转ActionCard类型
            //OapiRobot.OapiRobotActionCardOverall("乔布斯 20 年前想打造一间苹果咖啡厅，而它正是 Apple Store 的前身",
                                                //"![screenshot](@lADOpwk3K80C0M0FoA) \n #### 乔布斯 20 年前想打造的苹果咖啡厅 \n\n Apple Store 的设计正从原来满满的科技感走向生活化，而其生活化的走向其实可以追溯到 20 年前苹果一个建立咖啡馆的计划",
                                                //"阅读全文",
                                                //"https://www.dingtalk.com/",
                                                //"0",
            //"0");
            #endregion

            #region 4、独立跳转ActionCard类型
            //OapiRobot.OapiRobotActionCardSingle("乔布斯 20 年前想打造一间苹果咖啡厅，而它正是 Apple Store 的前身",
            //                                    "![screenshot](@lADOpwk3K80C0M0FoA) \n\n #### 乔布斯 20 年前想打造的苹果咖啡厅 \n\n Apple Store 的设计正从原来满满的科技感走向生活化，而其生活化的走向其实可以追溯到 20 年前苹果一个建立咖啡馆的计划",
            //                                    "[{\"title\": \"内容不错\", \"actionURL\": \"https://www.dingtalk.com/\"}, {\"title\": \"不感兴趣\", \"actionURL\": \"https://www.dingtalk.com/\"}]",
            //                                    "0",
            //                                    "0");
            #endregion

            #region 5、FeedCard类型
            OapiRobot.OapiRobotFeedCard();
            #endregion
        }
    }
}
