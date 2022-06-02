function getBodySize() {
    return {
        Width: screen.availWidth,
        Height: screen.availHeight
    }
}

function isDevice() {
    return /android|webos|iphone|ipad|ipod|blackberry|iemobile|opera mini|mobile/i.test(navigator.userAgent);
}

function getAvailableFonts() {
    var dataFont = {
        "windows": [{
            ZH: "宋体",
            EN: "SimSun"
        }, {
            ZH: "黑体",
            EN: "SimHei"
        }, {
            ZH: "微软雅黑",
            EN: "Microsoft Yahei"
        }, {
            ZH: "微软正黑体",
            EN: "Microsoft JhengHei"
        }, {
            ZH: "楷体",
            EN: "KaiTi"
        }, {
            ZH: "新宋体",
            EN: "NSimSun"
        }, {
            ZH: "仿宋",
            EN: "FangSong"
        }],
        "OS X": [{
            ZH: "苹方",
            EN: "PingFang SC"
        }, {
            ZH: "华文黑体",
            EN: "STHeiti"
        }, {
            ZH: "华文楷体",
            EN: "STKaiti"
        }, {
            ZH: "华文宋体",
            EN: "STSong"
        }, {
            ZH: "华文仿宋",
            EN: "STFangsong"
        }, {
            ZH: "华文中宋",
            EN: "STZhongsong"
        }, {
            ZH: "华文琥珀",
            EN: "STHupo"
        }, {
            ZH: "华文新魏",
            EN: "STXinwei"
        }, {
            ZH: "华文隶书",
            EN: "STLiti"
        }, {
            ZH: "华文行楷",
            EN: "STXingkai"
        }, {
            ZH: "冬青黑体简",
            EN: "Hiragino Sans GB"
        }, {
            ZH: "兰亭黑-简",
            EN: "Lantinghei SC"
        }, {
            ZH: "翩翩体-简",
            EN: "Hanzipen SC"
        }, {
            ZH: "手札体-简",
            EN: "Hannotate SC"
        }, {
            ZH: "宋体-简",
            EN: "Songti SC"
        }, {
            ZH: "娃娃体-简",
            EN: "Wawati SC"
        }, {
            ZH: "魏碑-简",
            EN: "Weibei SC"
        }, {
            ZH: "行楷-简",
            EN: "Xingkai SC"
        }, {
            ZH: "雅痞-简",
            EN: "Yapi SC"
        }, {
            ZH: "圆体-简",
            EN: "Yuanti SC"
        }],
        "office": [{
            ZH: "幼圆",
            EN: "YouYuan"
        }, {
            ZH: "隶书",
            EN: "LiSu"
        }, {
            ZH: "华文细黑",
            EN: "STXihei"
        }, {
            ZH: "华文楷体",
            EN: "STKaiti"
        }, {
            ZH: "华文宋体",
            EN: "STSong"
        }, {
            ZH: "华文仿宋",
            EN: "STFangsong"
        }, {
            ZH: "华文中宋",
            EN: "STZhongsong"
        }, {
            ZH: "华文彩云",
            EN: "STCaiyun"
        }, {
            ZH: "华文琥珀",
            EN: "STHupo"
        }, {
            ZH: "华文新魏",
            EN: "STXinwei"
        }, {
            ZH: "华文隶书",
            EN: "STLiti"
        }, {
            ZH: "华文行楷",
            EN: "STXingkai"
        }, {
            ZH: "方正舒体",
            EN: "FZShuTi"
        }, {
            ZH: "方正姚体",
            EN: "FZYaoti"
        }],
        "open": [{
            ZH: "思源黑体",
            EN: "Source Han Sans CN"
        }, {
            ZH: "思源宋体",
            EN: "Source Han Serif SC"
        }, {
            ZH: "文泉驿微米黑",
            EN: "WenQuanYi Micro Hei"
        }],
        "hanyi": [{
            ZH: "汉仪旗黑",
            EN: "HYQihei 40S"
        }, {
            ZH: "汉仪旗黑",
            EN: "HYQihei 50S"
        }, {
            ZH: "汉仪旗黑",
            EN: "HYQihei 60S"
        }, {
            ZH: "汉仪大宋简",
            EN: "HYDaSongJ"
        }, {
            ZH: "汉仪楷体",
            EN: "HYKaiti"
        }, {
            ZH: "汉仪家书简",
            EN: "HYJiaShuJ"
        }, {
            ZH: "汉仪PP体简",
            EN: "HYPPTiJ"
        }, {
            ZH: "汉仪乐喵体简",
            EN: "HYLeMiaoTi"
        }, {
            ZH: "汉仪小麦体",
            EN: "HYXiaoMaiTiJ"
        }, {
            ZH: "汉仪程行体",
            EN: "HYChengXingJ"
        }, {
            ZH: "汉仪黑荔枝",
            EN: "HYHeiLiZhiTiJ"
        }, {
            ZH: "汉仪雅酷黑W",
            EN: "HYYaKuHeiW"
        }, {
            ZH: "汉仪大黑简",
            EN: "HYDaHeiJ"
        }, {
            ZH: "汉仪尚魏手书W",
            EN: "HYShangWeiShouShuW"
        }],
        "fangzheng": [{
            ZH: "方正粗雅宋简体",
            EN: "FZYaSongS-B-GB"
        }, {
            ZH: "方正报宋简体",
            EN: "FZBaoSong-Z04S"
        }, {
            ZH: "方正粗圆简体",
            EN: "FZCuYuan-M03S"
        }, {
            ZH: "方正大标宋简体",
            EN: "FZDaBiaoSong-B06S"
        }, {
            ZH: "方正大黑简体",
            EN: "FZDaHei-B02S"
        }, {
            ZH: "方正仿宋简体",
            EN: "FZFangSong-Z02S"
        }, {
            ZH: "方正黑体简体",
            EN: "FZHei-B01S"
        }, {
            ZH: "方正琥珀简体",
            EN: "FZHuPo-M04S"
        }, {
            ZH: "方正楷体简体",
            EN: "FZKai-Z03S"
        }, {
            ZH: "方正隶变简体",
            EN: "FZLiBian-S02S"
        }, {
            ZH: "方正隶书简体",
            EN: "FZLiShu-S01S"
        }, {
            ZH: "方正美黑简体",
            EN: "FZMeiHei-M07S"
        }, {
            ZH: "方正书宋简体",
            EN: "FZShuSong-Z01S"
        }, {
            ZH: "方正舒体简体",
            EN: "FZShuTi-S05S"
        }, {
            ZH: "方正水柱简体",
            EN: "FZShuiZhu-M08S"
        }, {
            ZH: "方正宋黑简体",
            EN: "FZSongHei-B07S"
        }, {
            ZH: "方正宋三简体",
            EN: "FZSong"
        }, {
            ZH: "方正魏碑简体",
            EN: "FZWeiBei-S03S"
        }, {
            ZH: "方正细等线简体",
            EN: "FZXiDengXian-Z06S"
        }, {
            ZH: "方正细黑一简体",
            EN: "FZXiHei I-Z08S"
        }, {
            ZH: "方正细圆简体",
            EN: "FZXiYuan-M01S"
        }, {
            ZH: "方正小标宋简体",
            EN: "FZXiaoBiaoSong-B05S"
        }, {
            ZH: "方正行楷简体",
            EN: "FZXingKai-S04S"
        }, {
            ZH: "方正姚体简体",
            EN: "FZYaoTi-M06S"
        }, {
            ZH: "方正中等线简体",
            EN: "FZZhongDengXian-Z07S"
        }, {
            ZH: "方正准圆简体",
            EN: "FZZhunYuan-M02S"
        }, {
            ZH: "方正综艺简体",
            EN: "FZZongYi-M05S"
        }, {
            ZH: "方正彩云简体",
            EN: "FZCaiYun-M09S"
        }, {
            ZH: "方正隶二简体",
            EN: "FZLiShu II-S06S"
        }, {
            ZH: "方正康体简体",
            EN: "FZKangTi-S07S"
        }, {
            ZH: "方正超粗黑简体",
            EN: "FZChaoCuHei-M10S"
        }, {
            ZH: "方正新报宋简体",
            EN: "FZNew BaoSong-Z12S"
        }, {
            ZH: "方正新舒体简体",
            EN: "FZNew ShuTi-S08S"
        }, {
            ZH: "方正黄草简体",
            EN: "FZHuangCao-S09S"
        }, {
            ZH: "方正少儿简体",
            EN: "FZShaoEr-M11S"
        }, {
            ZH: "方正稚艺简体",
            EN: "FZZhiYi-M12S"
        }, {
            ZH: "方正细珊瑚简体",
            EN: "FZXiShanHu-M13S"
        }, {
            ZH: "方正粗宋简体",
            EN: "FZCuSong-B09S"
        }, {
            ZH: "方正平和简体",
            EN: "FZPingHe-S11S"
        }, {
            ZH: "方正华隶简体",
            EN: "FZHuaLi-M14S"
        }, {
            ZH: "方正瘦金书简体",
            EN: "FZShouJinShu-S10S"
        }, {
            ZH: "方正细倩简体",
            EN: "FZXiQian-M15S"
        }, {
            ZH: "方正中倩简体",
            EN: "FZZhongQian-M16S"
        }, {
            ZH: "方正粗倩简体",
            EN: "FZCuQian-M17S"
        }, {
            ZH: "方正胖娃简体",
            EN: "FZPangWa-M18S"
        }, {
            ZH: "方正宋一简体",
            EN: "FZSongYi-Z13S"
        }, {
            ZH: "方正剪纸简体",
            EN: "FZJianZhi-M23S"
        }, {
            ZH: "方正流行体简体",
            EN: "FZLiuXingTi-M26S"
        }, {
            ZH: "方正祥隶简体",
            EN: "FZXiangLi-S17S"
        }, {
            ZH: "方正粗活意简体",
            EN: "FZCuHuoYi-M25S"
        }, {
            ZH: "方正胖头鱼简体",
            EN: "FZPangTouYu-M24S"
        }, {
            ZH: "方正铁筋隶书简体",
            EN: "FZTieJinLiShu-Z14S"
        }, {
            ZH: "方正北魏楷书简体",
            EN: "FZBeiWeiKaiShu-Z15S"
        }, {
            ZH: "方正卡通简体",
            EN: "FZKaTong-M19S"
        }, {
            ZH: "方正艺黑简体",
            EN: "FZYiHei-M20S"
        }, {
            ZH: "方正水黑简体",
            EN: "FZShuiHei-M21S"
        }, {
            ZH: "方正古隶简体",
            EN: "FZGuLi-S12S"
        }, {
            ZH: "方正幼线简体",
            EN: "FZYouXian-Z09S"
        }, {
            ZH: "方正启体简体",
            EN: "FZQiTi-S14S"
        }, {
            ZH: "方正小篆体",
            EN: "FZXiaoZhuanTi-S13T"
        }, {
            ZH: "方正硬笔楷书简体",
            EN: "FZYingBiKaiShu-S15S"
        }, {
            ZH: "方正毡笔黑简体",
            EN: "FZZhanBiHei-M22S"
        }, {
            ZH: "方正硬笔行书简体",
            EN: "FZYingBiXingShu-S16S"
        }]
    };
    var arrFont =
        dataFont["windows"]
            .concat(
                dataFont["OS X"],
                dataFont["office"],
                dataFont["open"],
                dataFont["hanyi"],
                dataFont["fangzheng"]);
    var availableFonts = [];
    arrFont.forEach(function (font) {
        var isSupported = isSupportFontFamily(font.EN);
        if (isSupported) {
            availableFonts.push(font);
        }
    });
    return availableFonts;
}

function isSupportFontFamily(f) {
    if (typeof f != "string") {
        return false;
    }
    var h = "Arial";
    if (f.toLowerCase() == h.toLowerCase()) {
        return true;
    }
    var e = "a";
    var d = 100;
    var a = 100,
        i = 100;
    var c = document.createElement("canvas");
    var b = c.getContext("2d");
    c.width = a;
    c.height = i;
    b.textAlign = "center";
    b.fillStyle = "black";
    b.textBaseline = "middle";
    var g = function (j) {
        b.clearRect(0, 0, a, i);
        b.font = d + "px " + j + ", " + h;
        b.fillText(e, a / 2, i / 2);
        var k = b.getImageData(0, 0, a, i)
            .data;
        return [].slice.call(k)
            .filter(function (l) {
                return l != 0;
            });
    };
    return g(h).join("") != g(f).join("");
}

function getDefaultFont() {
    return (document.documentElement.currentStyle ? document.documentElement.currentStyle : window.getComputedStyle(document.documentElement)).fontFamily.trim().replace("\"", "").replace("\"", "");
}