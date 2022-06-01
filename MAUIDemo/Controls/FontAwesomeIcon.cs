﻿using System.ComponentModel;

namespace MAUIDemo.Controls
{
    ///<summary>
    ///	FontAwesome v4.7.0 by Dave Gandy (@davegandy)
    ///	The iconic font and CSS toolkit
    ///	License http://fontawesome.io/license (Font: v4.7.0, C#: MIT License)
    ///</summary>
    ///<see href="http://fontawesome.io" />
    ///<seealso href="https://github.com/FortAwesome/Font-Awesome" />
    ///<seealso href="https://github.com/charri/Font-Awesome-WPF" />
    public enum FontAwesomeIcon
    {
        ///<summary>Set this value to show no icon.</summary>
        None = 0x0,
        ///<summary>Glass (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/glass/" />
        [Description("Glass"), IconId("glass"), IconCategory("Web Application Icons")]
        Glass = 0xf000,
        ///<summary>Music (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/music/" />
        [Description("Music"), IconId("music"), IconCategory("Web Application Icons")]
        Music = 0xf001,
        ///<summary>Search (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/search/" />
        [Description("Search"), IconId("search"), IconCategory("Web Application Icons")]
        Search = 0xf002,
        ///<summary>Envelope Outlined (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/envelope-o/" />
        [Description("Envelope Outlined"), IconId("envelope-o"), IconCategory("Web Application Icons")]
        EnvelopeOutline = 0xf003,
        ///<summary>Heart (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/heart/" />
        [Description("Heart"), IconId("heart"), IconCategory("Web Application Icons"), IconCategory("Medical Icons")]
        Heart = 0xf004,
        ///<summary>Star (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/star/" />
        [Description("Star"), IconId("star"), IconCategory("Web Application Icons")]
        Star = 0xf005,
        ///<summary>Star Outlined (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/star-o/" />
        [Description("Star Outlined"), IconId("star-o"), IconCategory("Web Application Icons")]
        StarOutline = 0xf006,
        ///<summary>User (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/user/" />
        [Description("User"), IconId("user"), IconCategory("Web Application Icons")]
        User = 0xf007,
        ///<summary>Film (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/film/" />
        [Description("Film"), IconId("film"), IconCategory("Web Application Icons")]
        Film = 0xf008,
        ///<summary>th-large (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/th-large/" />
        [Description("th-large"), IconId("th-large"), IconCategory("Text Editor Icons")]
        ThLarge = 0xf009,
        ///<summary>th (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/th/" />
        [Description("th"), IconId("th"), IconCategory("Text Editor Icons")]
        Th = 0xf00a,
        ///<summary>th-list (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/th-list/" />
        [Description("th-list"), IconId("th-list"), IconCategory("Text Editor Icons")]
        ThList = 0xf00b,
        ///<summary>Check (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/check/" />
        [Description("Check"), IconId("check"), IconCategory("Web Application Icons")]
        Check = 0xf00c,
        ///<summary>Times (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/times/" />
        [Description("Times"), IconId("times"), IconCategory("Web Application Icons")]
        Times = 0xf00d,
        ///<summary>Alias of: Times</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Times" />
        [IconAlias]
        Remove = Times,
        ///<summary>Alias of: Times</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Times" />
        [IconAlias]
        Close = Times,
        ///<summary>Search Plus (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/search-plus/" />
        [Description("Search Plus"), IconId("search-plus"), IconCategory("Web Application Icons")]
        SearchPlus = 0xf00e,
        ///<summary>Search Minus (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/search-minus/" />
        [Description("Search Minus"), IconId("search-minus"), IconCategory("Web Application Icons")]
        SearchMinus = 0xf010,
        ///<summary>Power Off (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/power-off/" />
        [Description("Power Off"), IconId("power-off"), IconCategory("Web Application Icons")]
        PowerOff = 0xf011,
        ///<summary>signal (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/signal/" />
        [Description("signal"), IconId("signal"), IconCategory("Web Application Icons")]
        Signal = 0xf012,
        ///<summary>cog (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/cog/" />
        [Description("cog"), IconId("cog"), IconCategory("Web Application Icons"), IconCategory("Spinner Icons")]
        Cog = 0xf013,
        ///<summary>Alias of: Cog</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Cog" />
        [IconAlias]
        Gear = Cog,
        ///<summary>Trash Outlined (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/trash-o/" />
        [Description("Trash Outlined"), IconId("trash-o"), IconCategory("Web Application Icons")]
        TrashOutline = 0xf014,
        ///<summary>home (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/home/" />
        [Description("home"), IconId("home"), IconCategory("Web Application Icons")]
        Home = 0xf015,
        ///<summary>File Outlined (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/file-o/" />
        [Description("File Outlined"), IconId("file-o"), IconCategory("Text Editor Icons"), IconCategory("File Type Icons")]
        FileOutline = 0xf016,
        ///<summary>Clock Outlined (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/clock-o/" />
        [Description("Clock Outlined"), IconId("clock-o"), IconCategory("Web Application Icons")]
        ClockOutline = 0xf017,
        ///<summary>road (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/road/" />
        [Description("road"), IconId("road"), IconCategory("Web Application Icons")]
        Road = 0xf018,
        ///<summary>Download (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/download/" />
        [Description("Download"), IconId("download"), IconCategory("Web Application Icons")]
        Download = 0xf019,
        ///<summary>Arrow Circle Outlined Down (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/arrow-circle-o-down/" />
        [Description("Arrow Circle Outlined Down"), IconId("arrow-circle-o-down"), IconCategory("Directional Icons")]
        ArrowCircleOutlineDown = 0xf01a,
        ///<summary>Arrow Circle Outlined Up (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/arrow-circle-o-up/" />
        [Description("Arrow Circle Outlined Up"), IconId("arrow-circle-o-up"), IconCategory("Directional Icons")]
        ArrowCircleOutlineUp = 0xf01b,
        ///<summary>inbox (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/inbox/" />
        [Description("inbox"), IconId("inbox"), IconCategory("Web Application Icons")]
        Inbox = 0xf01c,
        ///<summary>Play Circle Outlined (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/play-circle-o/" />
        [Description("Play Circle Outlined"), IconId("play-circle-o"), IconCategory("Video Player Icons")]
        PlayCircleOutline = 0xf01d,
        ///<summary>Repeat (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/repeat/" />
        [Description("Repeat"), IconId("repeat"), IconCategory("Text Editor Icons")]
        Repeat = 0xf01e,
        ///<summary>Alias of: Repeat</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Repeat" />
        [IconAlias]
        RotateRight = Repeat,
        ///<summary>refresh (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/refresh/" />
        [Description("refresh"), IconId("refresh"), IconCategory("Web Application Icons"), IconCategory("Spinner Icons")]
        Refresh = 0xf021,
        ///<summary>list-alt (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/list-alt/" />
        [Description("list-alt"), IconId("list-alt"), IconCategory("Text Editor Icons")]
        ListAlt = 0xf022,
        ///<summary>lock (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/lock/" />
        [Description("lock"), IconId("lock"), IconCategory("Web Application Icons")]
        Lock = 0xf023,
        ///<summary>flag (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/flag/" />
        [Description("flag"), IconId("flag"), IconCategory("Web Application Icons")]
        Flag = 0xf024,
        ///<summary>headphones (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/headphones/" />
        [Description("headphones"), IconId("headphones"), IconCategory("Web Application Icons")]
        Headphones = 0xf025,
        ///<summary>volume-off (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/volume-off/" />
        [Description("volume-off"), IconId("volume-off"), IconCategory("Web Application Icons")]
        VolumeOff = 0xf026,
        ///<summary>volume-down (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/volume-down/" />
        [Description("volume-down"), IconId("volume-down"), IconCategory("Web Application Icons")]
        VolumeDown = 0xf027,
        ///<summary>volume-up (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/volume-up/" />
        [Description("volume-up"), IconId("volume-up"), IconCategory("Web Application Icons")]
        VolumeUp = 0xf028,
        ///<summary>qrcode (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/qrcode/" />
        [Description("qrcode"), IconId("qrcode"), IconCategory("Web Application Icons")]
        Qrcode = 0xf029,
        ///<summary>barcode (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/barcode/" />
        [Description("barcode"), IconId("barcode"), IconCategory("Web Application Icons")]
        Barcode = 0xf02a,
        ///<summary>tag (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/tag/" />
        [Description("tag"), IconId("tag"), IconCategory("Web Application Icons")]
        Tag = 0xf02b,
        ///<summary>tags (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/tags/" />
        [Description("tags"), IconId("tags"), IconCategory("Web Application Icons")]
        Tags = 0xf02c,
        ///<summary>book (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/book/" />
        [Description("book"), IconId("book"), IconCategory("Web Application Icons")]
        Book = 0xf02d,
        ///<summary>bookmark (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/bookmark/" />
        [Description("bookmark"), IconId("bookmark"), IconCategory("Web Application Icons")]
        Bookmark = 0xf02e,
        ///<summary>print (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/print/" />
        [Description("print"), IconId("print"), IconCategory("Web Application Icons")]
        Print = 0xf02f,
        ///<summary>camera (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/camera/" />
        [Description("camera"), IconId("camera"), IconCategory("Web Application Icons")]
        Camera = 0xf030,
        ///<summary>font (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/font/" />
        [Description("font"), IconId("font"), IconCategory("Text Editor Icons")]
        Font = 0xf031,
        ///<summary>bold (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/bold/" />
        [Description("bold"), IconId("bold"), IconCategory("Text Editor Icons")]
        Bold = 0xf032,
        ///<summary>italic (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/italic/" />
        [Description("italic"), IconId("italic"), IconCategory("Text Editor Icons")]
        Italic = 0xf033,
        ///<summary>text-height (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/text-height/" />
        [Description("text-height"), IconId("text-height"), IconCategory("Text Editor Icons")]
        TextHeight = 0xf034,
        ///<summary>text-width (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/text-width/" />
        [Description("text-width"), IconId("text-width"), IconCategory("Text Editor Icons")]
        TextWidth = 0xf035,
        ///<summary>align-left (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/align-left/" />
        [Description("align-left"), IconId("align-left"), IconCategory("Text Editor Icons")]
        AlignLeft = 0xf036,
        ///<summary>align-center (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/align-center/" />
        [Description("align-center"), IconId("align-center"), IconCategory("Text Editor Icons")]
        AlignCenter = 0xf037,
        ///<summary>align-right (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/align-right/" />
        [Description("align-right"), IconId("align-right"), IconCategory("Text Editor Icons")]
        AlignRight = 0xf038,
        ///<summary>align-justify (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/align-justify/" />
        [Description("align-justify"), IconId("align-justify"), IconCategory("Text Editor Icons")]
        AlignJustify = 0xf039,
        ///<summary>list (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/list/" />
        [Description("list"), IconId("list"), IconCategory("Text Editor Icons")]
        List = 0xf03a,
        ///<summary>Outdent (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/outdent/" />
        [Description("Outdent"), IconId("outdent"), IconCategory("Text Editor Icons")]
        Outdent = 0xf03b,
        ///<summary>Alias of: Outdent</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Outdent" />
        [IconAlias]
        Dedent = Outdent,
        ///<summary>Indent (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/indent/" />
        [Description("Indent"), IconId("indent"), IconCategory("Text Editor Icons")]
        Indent = 0xf03c,
        ///<summary>Video Camera (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/video-camera/" />
        [Description("Video Camera"), IconId("video-camera"), IconCategory("Web Application Icons")]
        VideoCamera = 0xf03d,
        ///<summary>Picture Outlined (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/picture-o/" />
        [Description("Picture Outlined"), IconId("picture-o"), IconCategory("Web Application Icons")]
        PictureOutline = 0xf03e,
        ///<summary>Alias of: PictureOutline</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.PictureOutline" />
        [IconAlias]
        Photo = PictureOutline,
        ///<summary>Alias of: PictureOutline</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.PictureOutline" />
        [IconAlias]
        Image = PictureOutline,
        ///<summary>pencil (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/pencil/" />
        [Description("pencil"), IconId("pencil"), IconCategory("Web Application Icons")]
        Pencil = 0xf040,
        ///<summary>map-marker (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/map-marker/" />
        [Description("map-marker"), IconId("map-marker"), IconCategory("Web Application Icons")]
        MapMarker = 0xf041,
        ///<summary>adjust (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/adjust/" />
        [Description("adjust"), IconId("adjust"), IconCategory("Web Application Icons")]
        Adjust = 0xf042,
        ///<summary>tint (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/tint/" />
        [Description("tint"), IconId("tint"), IconCategory("Web Application Icons")]
        Tint = 0xf043,
        ///<summary>Pencil Square Outlined (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/pencil-square-o/" />
        [Description("Pencil Square Outlined"), IconId("pencil-square-o"), IconCategory("Web Application Icons")]
        PencilSquareOutline = 0xf044,
        ///<summary>Alias of: PencilSquareOutline</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.PencilSquareOutline" />
        [IconAlias]
        Edit = PencilSquareOutline,
        ///<summary>Share Square Outlined (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/share-square-o/" />
        [Description("Share Square Outlined"), IconId("share-square-o"), IconCategory("Web Application Icons")]
        ShareSquareOutline = 0xf045,
        ///<summary>Check Square Outlined (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/check-square-o/" />
        [Description("Check Square Outlined"), IconId("check-square-o"), IconCategory("Web Application Icons"), IconCategory("Form Control Icons")]
        CheckSquareOutline = 0xf046,
        ///<summary>Arrows (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/arrows/" />
        [Description("Arrows"), IconId("arrows"), IconCategory("Web Application Icons"), IconCategory("Directional Icons")]
        Arrows = 0xf047,
        ///<summary>step-backward (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/step-backward/" />
        [Description("step-backward"), IconId("step-backward"), IconCategory("Video Player Icons")]
        StepBackward = 0xf048,
        ///<summary>fast-backward (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/fast-backward/" />
        [Description("fast-backward"), IconId("fast-backward"), IconCategory("Video Player Icons")]
        FastBackward = 0xf049,
        ///<summary>backward (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/backward/" />
        [Description("backward"), IconId("backward"), IconCategory("Video Player Icons")]
        Backward = 0xf04a,
        ///<summary>play (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/play/" />
        [Description("play"), IconId("play"), IconCategory("Video Player Icons")]
        Play = 0xf04b,
        ///<summary>pause (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/pause/" />
        [Description("pause"), IconId("pause"), IconCategory("Video Player Icons")]
        Pause = 0xf04c,
        ///<summary>stop (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/stop/" />
        [Description("stop"), IconId("stop"), IconCategory("Video Player Icons")]
        Stop = 0xf04d,
        ///<summary>forward (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/forward/" />
        [Description("forward"), IconId("forward"), IconCategory("Video Player Icons")]
        Forward = 0xf04e,
        ///<summary>fast-forward (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/fast-forward/" />
        [Description("fast-forward"), IconId("fast-forward"), IconCategory("Video Player Icons")]
        FastForward = 0xf050,
        ///<summary>step-forward (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/step-forward/" />
        [Description("step-forward"), IconId("step-forward"), IconCategory("Video Player Icons")]
        StepForward = 0xf051,
        ///<summary>eject (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/eject/" />
        [Description("eject"), IconId("eject"), IconCategory("Video Player Icons")]
        Eject = 0xf052,
        ///<summary>chevron-left (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/chevron-left/" />
        [Description("chevron-left"), IconId("chevron-left"), IconCategory("Directional Icons")]
        ChevronLeft = 0xf053,
        ///<summary>chevron-right (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/chevron-right/" />
        [Description("chevron-right"), IconId("chevron-right"), IconCategory("Directional Icons")]
        ChevronRight = 0xf054,
        ///<summary>Plus Circle (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/plus-circle/" />
        [Description("Plus Circle"), IconId("plus-circle"), IconCategory("Web Application Icons")]
        PlusCircle = 0xf055,
        ///<summary>Minus Circle (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/minus-circle/" />
        [Description("Minus Circle"), IconId("minus-circle"), IconCategory("Web Application Icons")]
        MinusCircle = 0xf056,
        ///<summary>Times Circle (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/times-circle/" />
        [Description("Times Circle"), IconId("times-circle"), IconCategory("Web Application Icons")]
        TimesCircle = 0xf057,
        ///<summary>Check Circle (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/check-circle/" />
        [Description("Check Circle"), IconId("check-circle"), IconCategory("Web Application Icons")]
        CheckCircle = 0xf058,
        ///<summary>Question Circle (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/question-circle/" />
        [Description("Question Circle"), IconId("question-circle"), IconCategory("Web Application Icons")]
        QuestionCircle = 0xf059,
        ///<summary>Info Circle (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/info-circle/" />
        [Description("Info Circle"), IconId("info-circle"), IconCategory("Web Application Icons")]
        InfoCircle = 0xf05a,
        ///<summary>Crosshairs (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/crosshairs/" />
        [Description("Crosshairs"), IconId("crosshairs"), IconCategory("Web Application Icons")]
        Crosshairs = 0xf05b,
        ///<summary>Times Circle Outlined (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/times-circle-o/" />
        [Description("Times Circle Outlined"), IconId("times-circle-o"), IconCategory("Web Application Icons")]
        TimesCircleOutline = 0xf05c,
        ///<summary>Check Circle Outlined (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/check-circle-o/" />
        [Description("Check Circle Outlined"), IconId("check-circle-o"), IconCategory("Web Application Icons")]
        CheckCircleOutline = 0xf05d,
        ///<summary>ban (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/ban/" />
        [Description("ban"), IconId("ban"), IconCategory("Web Application Icons")]
        Ban = 0xf05e,
        ///<summary>arrow-left (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/arrow-left/" />
        [Description("arrow-left"), IconId("arrow-left"), IconCategory("Directional Icons")]
        ArrowLeft = 0xf060,
        ///<summary>arrow-right (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/arrow-right/" />
        [Description("arrow-right"), IconId("arrow-right"), IconCategory("Directional Icons")]
        ArrowRight = 0xf061,
        ///<summary>arrow-up (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/arrow-up/" />
        [Description("arrow-up"), IconId("arrow-up"), IconCategory("Directional Icons")]
        ArrowUp = 0xf062,
        ///<summary>arrow-down (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/arrow-down/" />
        [Description("arrow-down"), IconId("arrow-down"), IconCategory("Directional Icons")]
        ArrowDown = 0xf063,
        ///<summary>Share (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/share/" />
        [Description("Share"), IconId("share"), IconCategory("Web Application Icons")]
        Share = 0xf064,
        ///<summary>Alias of: Share</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Share" />
        [IconAlias]
        MailForward = Share,
        ///<summary>Expand (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/expand/" />
        [Description("Expand"), IconId("expand"), IconCategory("Video Player Icons")]
        Expand = 0xf065,
        ///<summary>Compress (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/compress/" />
        [Description("Compress"), IconId("compress"), IconCategory("Video Player Icons")]
        Compress = 0xf066,
        ///<summary>plus (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/plus/" />
        [Description("plus"), IconId("plus"), IconCategory("Web Application Icons")]
        Plus = 0xf067,
        ///<summary>minus (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/minus/" />
        [Description("minus"), IconId("minus"), IconCategory("Web Application Icons")]
        Minus = 0xf068,
        ///<summary>asterisk (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/asterisk/" />
        [Description("asterisk"), IconId("asterisk"), IconCategory("Web Application Icons")]
        Asterisk = 0xf069,
        ///<summary>Exclamation Circle (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/exclamation-circle/" />
        [Description("Exclamation Circle"), IconId("exclamation-circle"), IconCategory("Web Application Icons")]
        ExclamationCircle = 0xf06a,
        ///<summary>gift (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/gift/" />
        [Description("gift"), IconId("gift"), IconCategory("Web Application Icons")]
        Gift = 0xf06b,
        ///<summary>leaf (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/leaf/" />
        [Description("leaf"), IconId("leaf"), IconCategory("Web Application Icons")]
        Leaf = 0xf06c,
        ///<summary>fire (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/fire/" />
        [Description("fire"), IconId("fire"), IconCategory("Web Application Icons")]
        Fire = 0xf06d,
        ///<summary>Eye (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/eye/" />
        [Description("Eye"), IconId("eye"), IconCategory("Web Application Icons")]
        Eye = 0xf06e,
        ///<summary>Eye Slash (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/eye-slash/" />
        [Description("Eye Slash"), IconId("eye-slash"), IconCategory("Web Application Icons")]
        EyeSlash = 0xf070,
        ///<summary>Exclamation Triangle (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/exclamation-triangle/" />
        [Description("Exclamation Triangle"), IconId("exclamation-triangle"), IconCategory("Web Application Icons")]
        ExclamationTriangle = 0xf071,
        ///<summary>Alias of: ExclamationTriangle</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.ExclamationTriangle" />
        [IconAlias]
        Warning = ExclamationTriangle,
        ///<summary>plane (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/plane/" />
        [Description("plane"), IconId("plane"), IconCategory("Web Application Icons"), IconCategory("Transportation Icons")]
        Plane = 0xf072,
        ///<summary>calendar (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/calendar/" />
        [Description("calendar"), IconId("calendar"), IconCategory("Web Application Icons")]
        Calendar = 0xf073,
        ///<summary>random (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/random/" />
        [Description("random"), IconId("random"), IconCategory("Web Application Icons"), IconCategory("Video Player Icons")]
        Random = 0xf074,
        ///<summary>comment (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/comment/" />
        [Description("comment"), IconId("comment"), IconCategory("Web Application Icons")]
        Comment = 0xf075,
        ///<summary>magnet (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/magnet/" />
        [Description("magnet"), IconId("magnet"), IconCategory("Web Application Icons")]
        Magnet = 0xf076,
        ///<summary>chevron-up (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/chevron-up/" />
        [Description("chevron-up"), IconId("chevron-up"), IconCategory("Directional Icons")]
        ChevronUp = 0xf077,
        ///<summary>chevron-down (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/chevron-down/" />
        [Description("chevron-down"), IconId("chevron-down"), IconCategory("Directional Icons")]
        ChevronDown = 0xf078,
        ///<summary>retweet (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/retweet/" />
        [Description("retweet"), IconId("retweet"), IconCategory("Web Application Icons")]
        Retweet = 0xf079,
        ///<summary>shopping-cart (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/shopping-cart/" />
        [Description("shopping-cart"), IconId("shopping-cart"), IconCategory("Web Application Icons")]
        ShoppingCart = 0xf07a,
        ///<summary>Folder (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/folder/" />
        [Description("Folder"), IconId("folder"), IconCategory("Web Application Icons")]
        Folder = 0xf07b,
        ///<summary>Folder Open (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/folder-open/" />
        [Description("Folder Open"), IconId("folder-open"), IconCategory("Web Application Icons")]
        FolderOpen = 0xf07c,
        ///<summary>Arrows Vertical (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/arrows-v/" />
        [Description("Arrows Vertical"), IconId("arrows-v"), IconCategory("Web Application Icons"), IconCategory("Directional Icons")]
        ArrowsV = 0xf07d,
        ///<summary>Arrows Horizontal (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/arrows-h/" />
        [Description("Arrows Horizontal"), IconId("arrows-h"), IconCategory("Web Application Icons"), IconCategory("Directional Icons")]
        ArrowsH = 0xf07e,
        ///<summary>Bar Chart (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/bar-chart/" />
        [Description("Bar Chart"), IconId("bar-chart"), IconCategory("Web Application Icons"), IconCategory("Chart Icons")]
        BarChart = 0xf080,
        ///<summary>Alias of: BarChart</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.BarChart" />
        [IconAlias]
        BarChartOutline = BarChart,
        ///<summary>Twitter Square (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/twitter-square/" />
        [Description("Twitter Square"), IconId("twitter-square"), IconCategory("Brand Icons")]
        TwitterSquare = 0xf081,
        ///<summary>Facebook Square (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/facebook-square/" />
        [Description("Facebook Square"), IconId("facebook-square"), IconCategory("Brand Icons")]
        FacebookSquare = 0xf082,
        ///<summary>camera-retro (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/camera-retro/" />
        [Description("camera-retro"), IconId("camera-retro"), IconCategory("Web Application Icons")]
        CameraRetro = 0xf083,
        ///<summary>key (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/key/" />
        [Description("key"), IconId("key"), IconCategory("Web Application Icons")]
        Key = 0xf084,
        ///<summary>cogs (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/cogs/" />
        [Description("cogs"), IconId("cogs"), IconCategory("Web Application Icons")]
        Cogs = 0xf085,
        ///<summary>Alias of: Cogs</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Cogs" />
        [IconAlias]
        Gears = Cogs,
        ///<summary>comments (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/comments/" />
        [Description("comments"), IconId("comments"), IconCategory("Web Application Icons")]
        Comments = 0xf086,
        ///<summary>Thumbs Up Outlined (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/thumbs-o-up/" />
        [Description("Thumbs Up Outlined"), IconId("thumbs-o-up"), IconCategory("Web Application Icons"), IconCategory("Hand Icons")]
        ThumbsOutlineUp = 0xf087,
        ///<summary>Thumbs Down Outlined (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/thumbs-o-down/" />
        [Description("Thumbs Down Outlined"), IconId("thumbs-o-down"), IconCategory("Web Application Icons"), IconCategory("Hand Icons")]
        ThumbsOutlineDown = 0xf088,
        ///<summary>star-half (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/star-half/" />
        [Description("star-half"), IconId("star-half"), IconCategory("Web Application Icons")]
        StarHalf = 0xf089,
        ///<summary>Heart Outlined (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/heart-o/" />
        [Description("Heart Outlined"), IconId("heart-o"), IconCategory("Web Application Icons"), IconCategory("Medical Icons")]
        HeartOutline = 0xf08a,
        ///<summary>Sign Out (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/sign-out/" />
        [Description("Sign Out"), IconId("sign-out"), IconCategory("Web Application Icons")]
        SignOut = 0xf08b,
        ///<summary>LinkedIn Square (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/linkedin-square/" />
        [Description("LinkedIn Square"), IconId("linkedin-square"), IconCategory("Brand Icons")]
        LinkedinSquare = 0xf08c,
        ///<summary>Thumb Tack (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/thumb-tack/" />
        [Description("Thumb Tack"), IconId("thumb-tack"), IconCategory("Web Application Icons")]
        ThumbTack = 0xf08d,
        ///<summary>External Link (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/external-link/" />
        [Description("External Link"), IconId("external-link"), IconCategory("Web Application Icons")]
        ExternalLink = 0xf08e,
        ///<summary>Sign In (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/sign-in/" />
        [Description("Sign In"), IconId("sign-in"), IconCategory("Web Application Icons")]
        SignIn = 0xf090,
        ///<summary>trophy (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/trophy/" />
        [Description("trophy"), IconId("trophy"), IconCategory("Web Application Icons")]
        Trophy = 0xf091,
        ///<summary>GitHub Square (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/github-square/" />
        [Description("GitHub Square"), IconId("github-square"), IconCategory("Brand Icons")]
        GithubSquare = 0xf092,
        ///<summary>Upload (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/upload/" />
        [Description("Upload"), IconId("upload"), IconCategory("Web Application Icons")]
        Upload = 0xf093,
        ///<summary>Lemon Outlined (created: 1.0)</summary>
        ///<see href="http://fontawesome.io/icon/lemon-o/" />
        [Description("Lemon Outlined"), IconId("lemon-o"), IconCategory("Web Application Icons")]
        LemonOutline = 0xf094,
        ///<summary>Phone (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/phone/" />
        [Description("Phone"), IconId("phone"), IconCategory("Web Application Icons")]
        Phone = 0xf095,
        ///<summary>Square Outlined (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/square-o/" />
        [Description("Square Outlined"), IconId("square-o"), IconCategory("Web Application Icons"), IconCategory("Form Control Icons")]
        SquareOutline = 0xf096,
        ///<summary>Bookmark Outlined (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/bookmark-o/" />
        [Description("Bookmark Outlined"), IconId("bookmark-o"), IconCategory("Web Application Icons")]
        BookmarkOutline = 0xf097,
        ///<summary>Phone Square (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/phone-square/" />
        [Description("Phone Square"), IconId("phone-square"), IconCategory("Web Application Icons")]
        PhoneSquare = 0xf098,
        ///<summary>Twitter (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/twitter/" />
        [Description("Twitter"), IconId("twitter"), IconCategory("Brand Icons")]
        Twitter = 0xf099,
        ///<summary>Facebook (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/facebook/" />
        [Description("Facebook"), IconId("facebook"), IconCategory("Brand Icons")]
        Facebook = 0xf09a,
        ///<summary>Alias of: Facebook</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Facebook" />
        [IconAlias]
        FacebookF = Facebook,
        ///<summary>GitHub (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/github/" />
        [Description("GitHub"), IconId("github"), IconCategory("Brand Icons")]
        Github = 0xf09b,
        ///<summary>unlock (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/unlock/" />
        [Description("unlock"), IconId("unlock"), IconCategory("Web Application Icons")]
        Unlock = 0xf09c,
        ///<summary>credit-card (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/credit-card/" />
        [Description("credit-card"), IconId("credit-card"), IconCategory("Web Application Icons"), IconCategory("Payment Icons")]
        CreditCard = 0xf09d,
        ///<summary>rss (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/rss/" />
        [Description("rss"), IconId("rss"), IconCategory("Web Application Icons")]
        Rss = 0xf09e,
        ///<summary>Alias of: Rss</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Rss" />
        [IconAlias]
        Feed = Rss,
        ///<summary>HDD (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/hdd-o/" />
        [Description("HDD"), IconId("hdd-o"), IconCategory("Web Application Icons")]
        HddOutline = 0xf0a0,
        ///<summary>bullhorn (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/bullhorn/" />
        [Description("bullhorn"), IconId("bullhorn"), IconCategory("Web Application Icons")]
        Bullhorn = 0xf0a1,
        ///<summary>bell (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/bell/" />
        [Description("bell"), IconId("bell"), IconCategory("Web Application Icons")]
        Bell = 0xf0f3,
        ///<summary>certificate (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/certificate/" />
        [Description("certificate"), IconId("certificate"), IconCategory("Web Application Icons")]
        Certificate = 0xf0a3,
        ///<summary>Hand Outlined Right (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/hand-o-right/" />
        [Description("Hand Outlined Right"), IconId("hand-o-right"), IconCategory("Directional Icons"), IconCategory("Hand Icons")]
        HandOutlineRight = 0xf0a4,
        ///<summary>Hand Outlined Left (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/hand-o-left/" />
        [Description("Hand Outlined Left"), IconId("hand-o-left"), IconCategory("Directional Icons"), IconCategory("Hand Icons")]
        HandOutlineLeft = 0xf0a5,
        ///<summary>Hand Outlined Up (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/hand-o-up/" />
        [Description("Hand Outlined Up"), IconId("hand-o-up"), IconCategory("Directional Icons"), IconCategory("Hand Icons")]
        HandOutlineUp = 0xf0a6,
        ///<summary>Hand Outlined Down (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/hand-o-down/" />
        [Description("Hand Outlined Down"), IconId("hand-o-down"), IconCategory("Directional Icons"), IconCategory("Hand Icons")]
        HandOutlineDown = 0xf0a7,
        ///<summary>Arrow Circle Left (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/arrow-circle-left/" />
        [Description("Arrow Circle Left"), IconId("arrow-circle-left"), IconCategory("Directional Icons")]
        ArrowCircleLeft = 0xf0a8,
        ///<summary>Arrow Circle Right (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/arrow-circle-right/" />
        [Description("Arrow Circle Right"), IconId("arrow-circle-right"), IconCategory("Directional Icons")]
        ArrowCircleRight = 0xf0a9,
        ///<summary>Arrow Circle Up (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/arrow-circle-up/" />
        [Description("Arrow Circle Up"), IconId("arrow-circle-up"), IconCategory("Directional Icons")]
        ArrowCircleUp = 0xf0aa,
        ///<summary>Arrow Circle Down (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/arrow-circle-down/" />
        [Description("Arrow Circle Down"), IconId("arrow-circle-down"), IconCategory("Directional Icons")]
        ArrowCircleDown = 0xf0ab,
        ///<summary>Globe (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/globe/" />
        [Description("Globe"), IconId("globe"), IconCategory("Web Application Icons")]
        Globe = 0xf0ac,
        ///<summary>Wrench (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/wrench/" />
        [Description("Wrench"), IconId("wrench"), IconCategory("Web Application Icons")]
        Wrench = 0xf0ad,
        ///<summary>Tasks (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/tasks/" />
        [Description("Tasks"), IconId("tasks"), IconCategory("Web Application Icons")]
        Tasks = 0xf0ae,
        ///<summary>Filter (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/filter/" />
        [Description("Filter"), IconId("filter"), IconCategory("Web Application Icons")]
        Filter = 0xf0b0,
        ///<summary>Briefcase (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/briefcase/" />
        [Description("Briefcase"), IconId("briefcase"), IconCategory("Web Application Icons")]
        Briefcase = 0xf0b1,
        ///<summary>Arrows Alt (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/arrows-alt/" />
        [Description("Arrows Alt"), IconId("arrows-alt"), IconCategory("Video Player Icons"), IconCategory("Directional Icons")]
        ArrowsAlt = 0xf0b2,
        ///<summary>Users (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/users/" />
        [Description("Users"), IconId("users"), IconCategory("Web Application Icons")]
        Users = 0xf0c0,
        ///<summary>Alias of: Users</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Users" />
        [IconAlias]
        Group = Users,
        ///<summary>Link (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/link/" />
        [Description("Link"), IconId("link"), IconCategory("Text Editor Icons")]
        Link = 0xf0c1,
        ///<summary>Alias of: Link</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Link" />
        [IconAlias]
        Chain = Link,
        ///<summary>Cloud (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/cloud/" />
        [Description("Cloud"), IconId("cloud"), IconCategory("Web Application Icons")]
        Cloud = 0xf0c2,
        ///<summary>Flask (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/flask/" />
        [Description("Flask"), IconId("flask"), IconCategory("Web Application Icons")]
        Flask = 0xf0c3,
        ///<summary>Scissors (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/scissors/" />
        [Description("Scissors"), IconId("scissors"), IconCategory("Text Editor Icons")]
        Scissors = 0xf0c4,
        ///<summary>Alias of: Scissors</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Scissors" />
        [IconAlias]
        Cut = Scissors,
        ///<summary>Files Outlined (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/files-o/" />
        [Description("Files Outlined"), IconId("files-o"), IconCategory("Text Editor Icons")]
        FilesOutline = 0xf0c5,
        ///<summary>Alias of: FilesOutline</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.FilesOutline" />
        [IconAlias]
        Copy = FilesOutline,
        ///<summary>Paperclip (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/paperclip/" />
        [Description("Paperclip"), IconId("paperclip"), IconCategory("Text Editor Icons")]
        Paperclip = 0xf0c6,
        ///<summary>Floppy Outlined (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/floppy-o/" />
        [Description("Floppy Outlined"), IconId("floppy-o"), IconCategory("Text Editor Icons")]
        FloppyOutline = 0xf0c7,
        ///<summary>Alias of: FloppyOutline</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.FloppyOutline" />
        [IconAlias]
        Save = FloppyOutline,
        ///<summary>Square (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/square/" />
        [Description("Square"), IconId("square"), IconCategory("Web Application Icons"), IconCategory("Form Control Icons")]
        Square = 0xf0c8,
        ///<summary>Bars (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/bars/" />
        [Description("Bars"), IconId("bars"), IconCategory("Web Application Icons")]
        Bars = 0xf0c9,
        ///<summary>Alias of: Bars</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Bars" />
        [IconAlias]
        Navicon = Bars,
        ///<summary>Alias of: Bars</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Bars" />
        [IconAlias]
        Reorder = Bars,
        ///<summary>list-ul (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/list-ul/" />
        [Description("list-ul"), IconId("list-ul"), IconCategory("Text Editor Icons")]
        ListUl = 0xf0ca,
        ///<summary>list-ol (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/list-ol/" />
        [Description("list-ol"), IconId("list-ol"), IconCategory("Text Editor Icons")]
        ListOl = 0xf0cb,
        ///<summary>Strikethrough (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/strikethrough/" />
        [Description("Strikethrough"), IconId("strikethrough"), IconCategory("Text Editor Icons")]
        Strikethrough = 0xf0cc,
        ///<summary>Underline (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/underline/" />
        [Description("Underline"), IconId("underline"), IconCategory("Text Editor Icons")]
        Underline = 0xf0cd,
        ///<summary>table (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/table/" />
        [Description("table"), IconId("table"), IconCategory("Text Editor Icons")]
        Table = 0xf0ce,
        ///<summary>magic (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/magic/" />
        [Description("magic"), IconId("magic"), IconCategory("Web Application Icons")]
        Magic = 0xf0d0,
        ///<summary>truck (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/truck/" />
        [Description("truck"), IconId("truck"), IconCategory("Web Application Icons"), IconCategory("Transportation Icons")]
        Truck = 0xf0d1,
        ///<summary>Pinterest (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/pinterest/" />
        [Description("Pinterest"), IconId("pinterest"), IconCategory("Brand Icons")]
        Pinterest = 0xf0d2,
        ///<summary>Pinterest Square (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/pinterest-square/" />
        [Description("Pinterest Square"), IconId("pinterest-square"), IconCategory("Brand Icons")]
        PinterestSquare = 0xf0d3,
        ///<summary>Google Plus Square (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/google-plus-square/" />
        [Description("Google Plus Square"), IconId("google-plus-square"), IconCategory("Brand Icons")]
        GooglePlusSquare = 0xf0d4,
        ///<summary>Google Plus (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/google-plus/" />
        [Description("Google Plus"), IconId("google-plus"), IconCategory("Brand Icons")]
        GooglePlus = 0xf0d5,
        ///<summary>Money (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/money/" />
        [Description("Money"), IconId("money"), IconCategory("Web Application Icons"), IconCategory("Currency Icons")]
        Money = 0xf0d6,
        ///<summary>Caret Down (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/caret-down/" />
        [Description("Caret Down"), IconId("caret-down"), IconCategory("Directional Icons")]
        CaretDown = 0xf0d7,
        ///<summary>Caret Up (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/caret-up/" />
        [Description("Caret Up"), IconId("caret-up"), IconCategory("Directional Icons")]
        CaretUp = 0xf0d8,
        ///<summary>Caret Left (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/caret-left/" />
        [Description("Caret Left"), IconId("caret-left"), IconCategory("Directional Icons")]
        CaretLeft = 0xf0d9,
        ///<summary>Caret Right (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/caret-right/" />
        [Description("Caret Right"), IconId("caret-right"), IconCategory("Directional Icons")]
        CaretRight = 0xf0da,
        ///<summary>Columns (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/columns/" />
        [Description("Columns"), IconId("columns"), IconCategory("Text Editor Icons")]
        Columns = 0xf0db,
        ///<summary>Sort (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/sort/" />
        [Description("Sort"), IconId("sort"), IconCategory("Web Application Icons")]
        Sort = 0xf0dc,
        ///<summary>Alias of: Sort</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Sort" />
        [IconAlias]
        Unsorted = Sort,
        ///<summary>Sort Descending (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/sort-desc/" />
        [Description("Sort Descending"), IconId("sort-desc"), IconCategory("Web Application Icons")]
        SortDesc = 0xf0dd,
        ///<summary>Alias of: SortDesc</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.SortDesc" />
        [IconAlias]
        SortDown = SortDesc,
        ///<summary>Sort Ascending (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/sort-asc/" />
        [Description("Sort Ascending"), IconId("sort-asc"), IconCategory("Web Application Icons")]
        SortAsc = 0xf0de,
        ///<summary>Alias of: SortAsc</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.SortAsc" />
        [IconAlias]
        SortUp = SortAsc,
        ///<summary>Envelope (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/envelope/" />
        [Description("Envelope"), IconId("envelope"), IconCategory("Web Application Icons")]
        Envelope = 0xf0e0,
        ///<summary>LinkedIn (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/linkedin/" />
        [Description("LinkedIn"), IconId("linkedin"), IconCategory("Brand Icons")]
        Linkedin = 0xf0e1,
        ///<summary>Undo (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/undo/" />
        [Description("Undo"), IconId("undo"), IconCategory("Text Editor Icons")]
        Undo = 0xf0e2,
        ///<summary>Alias of: Undo</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Undo" />
        [IconAlias]
        RotateLeft = Undo,
        ///<summary>Gavel (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/gavel/" />
        [Description("Gavel"), IconId("gavel"), IconCategory("Web Application Icons")]
        Gavel = 0xf0e3,
        ///<summary>Alias of: Gavel</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Gavel" />
        [IconAlias]
        Legal = Gavel,
        ///<summary>Tachometer (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/tachometer/" />
        [Description("Tachometer"), IconId("tachometer"), IconCategory("Web Application Icons")]
        Tachometer = 0xf0e4,
        ///<summary>Alias of: Tachometer</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Tachometer" />
        [IconAlias]
        Dashboard = Tachometer,
        ///<summary>comment-o (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/comment-o/" />
        [Description("comment-o"), IconId("comment-o"), IconCategory("Web Application Icons")]
        CommentOutline = 0xf0e5,
        ///<summary>comments-o (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/comments-o/" />
        [Description("comments-o"), IconId("comments-o"), IconCategory("Web Application Icons")]
        CommentsOutline = 0xf0e6,
        ///<summary>Lightning Bolt (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/bolt/" />
        [Description("Lightning Bolt"), IconId("bolt"), IconCategory("Web Application Icons")]
        Bolt = 0xf0e7,
        ///<summary>Alias of: Bolt</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Bolt" />
        [IconAlias]
        Flash = Bolt,
        ///<summary>Sitemap (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/sitemap/" />
        [Description("Sitemap"), IconId("sitemap"), IconCategory("Web Application Icons")]
        Sitemap = 0xf0e8,
        ///<summary>Umbrella (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/umbrella/" />
        [Description("Umbrella"), IconId("umbrella"), IconCategory("Web Application Icons")]
        Umbrella = 0xf0e9,
        ///<summary>Clipboard (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/clipboard/" />
        [Description("Clipboard"), IconId("clipboard"), IconCategory("Text Editor Icons")]
        Clipboard = 0xf0ea,
        ///<summary>Alias of: Clipboard</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Clipboard" />
        [IconAlias]
        Paste = Clipboard,
        ///<summary>Lightbulb Outlined (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/lightbulb-o/" />
        [Description("Lightbulb Outlined"), IconId("lightbulb-o"), IconCategory("Web Application Icons")]
        LightbulbOutline = 0xf0eb,
        ///<summary>Exchange (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/exchange/" />
        [Description("Exchange"), IconId("exchange"), IconCategory("Web Application Icons"), IconCategory("Directional Icons")]
        Exchange = 0xf0ec,
        ///<summary>Cloud Download (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/cloud-download/" />
        [Description("Cloud Download"), IconId("cloud-download"), IconCategory("Web Application Icons")]
        CloudDownload = 0xf0ed,
        ///<summary>Cloud Upload (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/cloud-upload/" />
        [Description("Cloud Upload"), IconId("cloud-upload"), IconCategory("Web Application Icons")]
        CloudUpload = 0xf0ee,
        ///<summary>user-md (created: 2.0)</summary>
        ///<see href="http://fontawesome.io/icon/user-md/" />
        [Description("user-md"), IconId("user-md"), IconCategory("Medical Icons")]
        UserMd = 0xf0f0,
        ///<summary>Stethoscope (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/stethoscope/" />
        [Description("Stethoscope"), IconId("stethoscope"), IconCategory("Medical Icons")]
        Stethoscope = 0xf0f1,
        ///<summary>Suitcase (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/suitcase/" />
        [Description("Suitcase"), IconId("suitcase"), IconCategory("Web Application Icons")]
        Suitcase = 0xf0f2,
        ///<summary>Bell Outlined (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/bell-o/" />
        [Description("Bell Outlined"), IconId("bell-o"), IconCategory("Web Application Icons")]
        BellOutline = 0xf0a2,
        ///<summary>Coffee (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/coffee/" />
        [Description("Coffee"), IconId("coffee"), IconCategory("Web Application Icons")]
        Coffee = 0xf0f4,
        ///<summary>Cutlery (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/cutlery/" />
        [Description("Cutlery"), IconId("cutlery"), IconCategory("Web Application Icons")]
        Cutlery = 0xf0f5,
        ///<summary>File Text Outlined (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/file-text-o/" />
        [Description("File Text Outlined"), IconId("file-text-o"), IconCategory("Text Editor Icons"), IconCategory("File Type Icons")]
        FileTextOutline = 0xf0f6,
        ///<summary>Building Outlined (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/building-o/" />
        [Description("Building Outlined"), IconId("building-o"), IconCategory("Web Application Icons")]
        BuildingOutline = 0xf0f7,
        ///<summary>hospital Outlined (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/hospital-o/" />
        [Description("hospital Outlined"), IconId("hospital-o"), IconCategory("Medical Icons")]
        HospitalOutline = 0xf0f8,
        ///<summary>ambulance (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/ambulance/" />
        [Description("ambulance"), IconId("ambulance"), IconCategory("Medical Icons"), IconCategory("Transportation Icons")]
        Ambulance = 0xf0f9,
        ///<summary>medkit (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/medkit/" />
        [Description("medkit"), IconId("medkit"), IconCategory("Medical Icons")]
        Medkit = 0xf0fa,
        ///<summary>fighter-jet (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/fighter-jet/" />
        [Description("fighter-jet"), IconId("fighter-jet"), IconCategory("Web Application Icons"), IconCategory("Transportation Icons")]
        FighterJet = 0xf0fb,
        ///<summary>beer (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/beer/" />
        [Description("beer"), IconId("beer"), IconCategory("Web Application Icons")]
        Beer = 0xf0fc,
        ///<summary>H Square (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/h-square/" />
        [Description("H Square"), IconId("h-square"), IconCategory("Medical Icons")]
        HSquare = 0xf0fd,
        ///<summary>Plus Square (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/plus-square/" />
        [Description("Plus Square"), IconId("plus-square"), IconCategory("Medical Icons"), IconCategory("Web Application Icons"), IconCategory("Form Control Icons")]
        PlusSquare = 0xf0fe,
        ///<summary>Angle Double Left (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/angle-double-left/" />
        [Description("Angle Double Left"), IconId("angle-double-left"), IconCategory("Directional Icons")]
        AngleDoubleLeft = 0xf100,
        ///<summary>Angle Double Right (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/angle-double-right/" />
        [Description("Angle Double Right"), IconId("angle-double-right"), IconCategory("Directional Icons")]
        AngleDoubleRight = 0xf101,
        ///<summary>Angle Double Up (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/angle-double-up/" />
        [Description("Angle Double Up"), IconId("angle-double-up"), IconCategory("Directional Icons")]
        AngleDoubleUp = 0xf102,
        ///<summary>Angle Double Down (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/angle-double-down/" />
        [Description("Angle Double Down"), IconId("angle-double-down"), IconCategory("Directional Icons")]
        AngleDoubleDown = 0xf103,
        ///<summary>angle-left (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/angle-left/" />
        [Description("angle-left"), IconId("angle-left"), IconCategory("Directional Icons")]
        AngleLeft = 0xf104,
        ///<summary>angle-right (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/angle-right/" />
        [Description("angle-right"), IconId("angle-right"), IconCategory("Directional Icons")]
        AngleRight = 0xf105,
        ///<summary>angle-up (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/angle-up/" />
        [Description("angle-up"), IconId("angle-up"), IconCategory("Directional Icons")]
        AngleUp = 0xf106,
        ///<summary>angle-down (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/angle-down/" />
        [Description("angle-down"), IconId("angle-down"), IconCategory("Directional Icons")]
        AngleDown = 0xf107,
        ///<summary>Desktop (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/desktop/" />
        [Description("Desktop"), IconId("desktop"), IconCategory("Web Application Icons")]
        Desktop = 0xf108,
        ///<summary>Laptop (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/laptop/" />
        [Description("Laptop"), IconId("laptop"), IconCategory("Web Application Icons")]
        Laptop = 0xf109,
        ///<summary>tablet (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/tablet/" />
        [Description("tablet"), IconId("tablet"), IconCategory("Web Application Icons")]
        Tablet = 0xf10a,
        ///<summary>Mobile Phone (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/mobile/" />
        [Description("Mobile Phone"), IconId("mobile"), IconCategory("Web Application Icons")]
        Mobile = 0xf10b,
        ///<summary>Alias of: Mobile</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Mobile" />
        [IconAlias]
        MobilePhone = Mobile,
        ///<summary>Circle Outlined (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/circle-o/" />
        [Description("Circle Outlined"), IconId("circle-o"), IconCategory("Web Application Icons"), IconCategory("Form Control Icons")]
        CircleOutline = 0xf10c,
        ///<summary>quote-left (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/quote-left/" />
        [Description("quote-left"), IconId("quote-left"), IconCategory("Web Application Icons")]
        QuoteLeft = 0xf10d,
        ///<summary>quote-right (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/quote-right/" />
        [Description("quote-right"), IconId("quote-right"), IconCategory("Web Application Icons")]
        QuoteRight = 0xf10e,
        ///<summary>Spinner (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/spinner/" />
        [Description("Spinner"), IconId("spinner"), IconCategory("Web Application Icons"), IconCategory("Spinner Icons")]
        Spinner = 0xf110,
        ///<summary>Circle (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/circle/" />
        [Description("Circle"), IconId("circle"), IconCategory("Web Application Icons"), IconCategory("Form Control Icons")]
        Circle = 0xf111,
        ///<summary>Reply (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/reply/" />
        [Description("Reply"), IconId("reply"), IconCategory("Web Application Icons")]
        Reply = 0xf112,
        ///<summary>Alias of: Reply</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Reply" />
        [IconAlias]
        MailReply = Reply,
        ///<summary>GitHub Alt (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/github-alt/" />
        [Description("GitHub Alt"), IconId("github-alt"), IconCategory("Brand Icons")]
        GithubAlt = 0xf113,
        ///<summary>Folder Outlined (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/folder-o/" />
        [Description("Folder Outlined"), IconId("folder-o"), IconCategory("Web Application Icons")]
        FolderOutline = 0xf114,
        ///<summary>Folder Open Outlined (created: 3.0)</summary>
        ///<see href="http://fontawesome.io/icon/folder-open-o/" />
        [Description("Folder Open Outlined"), IconId("folder-open-o"), IconCategory("Web Application Icons")]
        FolderOutlinepenOutline = 0xf115,
        ///<summary>Smile Outlined (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/smile-o/" />
        [Description("Smile Outlined"), IconId("smile-o"), IconCategory("Web Application Icons")]
        SmileOutline = 0xf118,
        ///<summary>Frown Outlined (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/frown-o/" />
        [Description("Frown Outlined"), IconId("frown-o"), IconCategory("Web Application Icons")]
        FrownOutline = 0xf119,
        ///<summary>Meh Outlined (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/meh-o/" />
        [Description("Meh Outlined"), IconId("meh-o"), IconCategory("Web Application Icons")]
        MehOutline = 0xf11a,
        ///<summary>Gamepad (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/gamepad/" />
        [Description("Gamepad"), IconId("gamepad"), IconCategory("Web Application Icons")]
        Gamepad = 0xf11b,
        ///<summary>Keyboard Outlined (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/keyboard-o/" />
        [Description("Keyboard Outlined"), IconId("keyboard-o"), IconCategory("Web Application Icons")]
        KeyboardOutline = 0xf11c,
        ///<summary>Flag Outlined (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/flag-o/" />
        [Description("Flag Outlined"), IconId("flag-o"), IconCategory("Web Application Icons")]
        FlagOutline = 0xf11d,
        ///<summary>flag-checkered (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/flag-checkered/" />
        [Description("flag-checkered"), IconId("flag-checkered"), IconCategory("Web Application Icons")]
        FlagCheckered = 0xf11e,
        ///<summary>Terminal (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/terminal/" />
        [Description("Terminal"), IconId("terminal"), IconCategory("Web Application Icons")]
        Terminal = 0xf120,
        ///<summary>Code (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/code/" />
        [Description("Code"), IconId("code"), IconCategory("Web Application Icons")]
        Code = 0xf121,
        ///<summary>reply-all (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/reply-all/" />
        [Description("reply-all"), IconId("reply-all"), IconCategory("Web Application Icons")]
        ReplyAll = 0xf122,
        ///<summary>Alias of: ReplyAll</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.ReplyAll" />
        [IconAlias]
        MailReplyAll = ReplyAll,
        ///<summary>Star Half Outlined (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/star-half-o/" />
        [Description("Star Half Outlined"), IconId("star-half-o"), IconCategory("Web Application Icons")]
        StarHalfOutline = 0xf123,
        ///<summary>Alias of: StarHalfOutline</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.StarHalfOutline" />
        [IconAlias]
        StarHalfEmpty = StarHalfOutline,
        ///<summary>Alias of: StarHalfOutline</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.StarHalfOutline" />
        [IconAlias]
        StarHalfFull = StarHalfOutline,
        ///<summary>location-arrow (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/location-arrow/" />
        [Description("location-arrow"), IconId("location-arrow"), IconCategory("Web Application Icons")]
        LocationArrow = 0xf124,
        ///<summary>crop (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/crop/" />
        [Description("crop"), IconId("crop"), IconCategory("Web Application Icons")]
        Crop = 0xf125,
        ///<summary>code-fork (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/code-fork/" />
        [Description("code-fork"), IconId("code-fork"), IconCategory("Web Application Icons")]
        CodeFork = 0xf126,
        ///<summary>Chain Broken (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/chain-broken/" />
        [Description("Chain Broken"), IconId("chain-broken"), IconCategory("Text Editor Icons")]
        ChainBroken = 0xf127,
        ///<summary>Alias of: ChainBroken</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.ChainBroken" />
        [IconAlias]
        Unlink = ChainBroken,
        ///<summary>Question (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/question/" />
        [Description("Question"), IconId("question"), IconCategory("Web Application Icons")]
        Question = 0xf128,
        ///<summary>Info (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/info/" />
        [Description("Info"), IconId("info"), IconCategory("Web Application Icons")]
        Info = 0xf129,
        ///<summary>exclamation (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/exclamation/" />
        [Description("exclamation"), IconId("exclamation"), IconCategory("Web Application Icons")]
        Exclamation = 0xf12a,
        ///<summary>superscript (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/superscript/" />
        [Description("superscript"), IconId("superscript"), IconCategory("Text Editor Icons")]
        Superscript = 0xf12b,
        ///<summary>subscript (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/subscript/" />
        [Description("subscript"), IconId("subscript"), IconCategory("Text Editor Icons")]
        Subscript = 0xf12c,
        ///<summary>eraser (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/eraser/" />
        [Description("eraser"), IconId("eraser"), IconCategory("Text Editor Icons"), IconCategory("Web Application Icons")]
        Eraser = 0xf12d,
        ///<summary>Puzzle Piece (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/puzzle-piece/" />
        [Description("Puzzle Piece"), IconId("puzzle-piece"), IconCategory("Web Application Icons")]
        PuzzlePiece = 0xf12e,
        ///<summary>microphone (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/microphone/" />
        [Description("microphone"), IconId("microphone"), IconCategory("Web Application Icons")]
        Microphone = 0xf130,
        ///<summary>Microphone Slash (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/microphone-slash/" />
        [Description("Microphone Slash"), IconId("microphone-slash"), IconCategory("Web Application Icons")]
        MicrophoneSlash = 0xf131,
        ///<summary>shield (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/shield/" />
        [Description("shield"), IconId("shield"), IconCategory("Web Application Icons")]
        Shield = 0xf132,
        ///<summary>calendar-o (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/calendar-o/" />
        [Description("calendar-o"), IconId("calendar-o"), IconCategory("Web Application Icons")]
        CalendarOutline = 0xf133,
        ///<summary>fire-extinguisher (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/fire-extinguisher/" />
        [Description("fire-extinguisher"), IconId("fire-extinguisher"), IconCategory("Web Application Icons")]
        FireExtinguisher = 0xf134,
        ///<summary>rocket (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/rocket/" />
        [Description("rocket"), IconId("rocket"), IconCategory("Web Application Icons"), IconCategory("Transportation Icons")]
        Rocket = 0xf135,
        ///<summary>MaxCDN (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/maxcdn/" />
        [Description("MaxCDN"), IconId("maxcdn"), IconCategory("Brand Icons")]
        Maxcdn = 0xf136,
        ///<summary>Chevron Circle Left (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/chevron-circle-left/" />
        [Description("Chevron Circle Left"), IconId("chevron-circle-left"), IconCategory("Directional Icons")]
        ChevronCircleLeft = 0xf137,
        ///<summary>Chevron Circle Right (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/chevron-circle-right/" />
        [Description("Chevron Circle Right"), IconId("chevron-circle-right"), IconCategory("Directional Icons")]
        ChevronCircleRight = 0xf138,
        ///<summary>Chevron Circle Up (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/chevron-circle-up/" />
        [Description("Chevron Circle Up"), IconId("chevron-circle-up"), IconCategory("Directional Icons")]
        ChevronCircleUp = 0xf139,
        ///<summary>Chevron Circle Down (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/chevron-circle-down/" />
        [Description("Chevron Circle Down"), IconId("chevron-circle-down"), IconCategory("Directional Icons")]
        ChevronCircleDown = 0xf13a,
        ///<summary>HTML 5 Logo (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/html5/" />
        [Description("HTML 5 Logo"), IconId("html5"), IconCategory("Brand Icons")]
        Html5 = 0xf13b,
        ///<summary>CSS 3 Logo (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/css3/" />
        [Description("CSS 3 Logo"), IconId("css3"), IconCategory("Brand Icons")]
        Css3 = 0xf13c,
        ///<summary>Anchor (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/anchor/" />
        [Description("Anchor"), IconId("anchor"), IconCategory("Web Application Icons")]
        Anchor = 0xf13d,
        ///<summary>Unlock Alt (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/unlock-alt/" />
        [Description("Unlock Alt"), IconId("unlock-alt"), IconCategory("Web Application Icons")]
        UnlockAlt = 0xf13e,
        ///<summary>Bullseye (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/bullseye/" />
        [Description("Bullseye"), IconId("bullseye"), IconCategory("Web Application Icons")]
        Bullseye = 0xf140,
        ///<summary>Ellipsis Horizontal (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/ellipsis-h/" />
        [Description("Ellipsis Horizontal"), IconId("ellipsis-h"), IconCategory("Web Application Icons")]
        EllipsisH = 0xf141,
        ///<summary>Ellipsis Vertical (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/ellipsis-v/" />
        [Description("Ellipsis Vertical"), IconId("ellipsis-v"), IconCategory("Web Application Icons")]
        EllipsisV = 0xf142,
        ///<summary>RSS Square (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/rss-square/" />
        [Description("RSS Square"), IconId("rss-square"), IconCategory("Web Application Icons")]
        RssSquare = 0xf143,
        ///<summary>Play Circle (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/play-circle/" />
        [Description("Play Circle"), IconId("play-circle"), IconCategory("Video Player Icons")]
        PlayCircle = 0xf144,
        ///<summary>Ticket (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/ticket/" />
        [Description("Ticket"), IconId("ticket"), IconCategory("Web Application Icons")]
        Ticket = 0xf145,
        ///<summary>Minus Square (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/minus-square/" />
        [Description("Minus Square"), IconId("minus-square"), IconCategory("Web Application Icons"), IconCategory("Form Control Icons")]
        MinusSquare = 0xf146,
        ///<summary>Minus Square Outlined (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/minus-square-o/" />
        [Description("Minus Square Outlined"), IconId("minus-square-o"), IconCategory("Web Application Icons"), IconCategory("Form Control Icons")]
        MinusSquareOutline = 0xf147,
        ///<summary>Level Up (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/level-up/" />
        [Description("Level Up"), IconId("level-up"), IconCategory("Web Application Icons")]
        LevelUp = 0xf148,
        ///<summary>Level Down (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/level-down/" />
        [Description("Level Down"), IconId("level-down"), IconCategory("Web Application Icons")]
        LevelDown = 0xf149,
        ///<summary>Check Square (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/check-square/" />
        [Description("Check Square"), IconId("check-square"), IconCategory("Web Application Icons"), IconCategory("Form Control Icons")]
        CheckSquare = 0xf14a,
        ///<summary>Pencil Square (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/pencil-square/" />
        [Description("Pencil Square"), IconId("pencil-square"), IconCategory("Web Application Icons")]
        PencilSquare = 0xf14b,
        ///<summary>External Link Square (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/external-link-square/" />
        [Description("External Link Square"), IconId("external-link-square"), IconCategory("Web Application Icons")]
        ExternalLinkSquare = 0xf14c,
        ///<summary>Share Square (created: 3.1)</summary>
        ///<see href="http://fontawesome.io/icon/share-square/" />
        [Description("Share Square"), IconId("share-square"), IconCategory("Web Application Icons")]
        ShareSquare = 0xf14d,
        ///<summary>Compass (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/compass/" />
        [Description("Compass"), IconId("compass"), IconCategory("Web Application Icons")]
        Compass = 0xf14e,
        ///<summary>Caret Square Outlined Down (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/caret-square-o-down/" />
        [Description("Caret Square Outlined Down"), IconId("caret-square-o-down"), IconCategory("Web Application Icons"), IconCategory("Directional Icons")]
        CaretSquareOutlineDown = 0xf150,
        ///<summary>Alias of: CaretSquareOutlineDown</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.CaretSquareOutlineDown" />
        [IconAlias]
        ToggleDown = CaretSquareOutlineDown,
        ///<summary>Caret Square Outlined Up (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/caret-square-o-up/" />
        [Description("Caret Square Outlined Up"), IconId("caret-square-o-up"), IconCategory("Web Application Icons"), IconCategory("Directional Icons")]
        CaretSquareOutlineUp = 0xf151,
        ///<summary>Alias of: CaretSquareOutlineUp</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.CaretSquareOutlineUp" />
        [IconAlias]
        ToggleUp = CaretSquareOutlineUp,
        ///<summary>Caret Square Outlined Right (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/caret-square-o-right/" />
        [Description("Caret Square Outlined Right"), IconId("caret-square-o-right"), IconCategory("Web Application Icons"), IconCategory("Directional Icons")]
        CaretSquareOutlineRight = 0xf152,
        ///<summary>Alias of: CaretSquareOutlineRight</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.CaretSquareOutlineRight" />
        [IconAlias]
        ToggleRight = CaretSquareOutlineRight,
        ///<summary>Euro (EUR) (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/eur/" />
        [Description("Euro (EUR)"), IconId("eur"), IconCategory("Currency Icons")]
        Eur = 0xf153,
        ///<summary>Alias of: Eur</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Eur" />
        [IconAlias]
        Euro = Eur,
        ///<summary>GBP (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/gbp/" />
        [Description("GBP"), IconId("gbp"), IconCategory("Currency Icons")]
        Gbp = 0xf154,
        ///<summary>US Dollar (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/usd/" />
        [Description("US Dollar"), IconId("usd"), IconCategory("Currency Icons")]
        Usd = 0xf155,
        ///<summary>Alias of: Usd</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Usd" />
        [IconAlias]
        Dollar = Usd,
        ///<summary>Indian Rupee (INR) (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/inr/" />
        [Description("Indian Rupee (INR)"), IconId("inr"), IconCategory("Currency Icons")]
        Inr = 0xf156,
        ///<summary>Alias of: Inr</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Inr" />
        [IconAlias]
        Rupee = Inr,
        ///<summary>Japanese Yen (JPY) (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/jpy/" />
        [Description("Japanese Yen (JPY)"), IconId("jpy"), IconCategory("Currency Icons")]
        Jpy = 0xf157,
        ///<summary>Alias of: Jpy</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Jpy" />
        [IconAlias]
        Cny = Jpy,
        ///<summary>Alias of: Jpy</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Jpy" />
        [IconAlias]
        Rmb = Jpy,
        ///<summary>Alias of: Jpy</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Jpy" />
        [IconAlias]
        Yen = Jpy,
        ///<summary>Russian Ruble (RUB) (created: 4.0)</summary>
        ///<see href="http://fontawesome.io/icon/rub/" />
        [Description("Russian Ruble (RUB)"), IconId("rub"), IconCategory("Currency Icons")]
        Rub = 0xf158,
        ///<summary>Alias of: Rub</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Rub" />
        [IconAlias]
        Ruble = Rub,
        ///<summary>Alias of: Rub</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Rub" />
        [IconAlias]
        Rouble = Rub,
        ///<summary>Korean Won (KRW) (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/krw/" />
        [Description("Korean Won (KRW)"), IconId("krw"), IconCategory("Currency Icons")]
        Krw = 0xf159,
        ///<summary>Alias of: Krw</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Krw" />
        [IconAlias]
        Won = Krw,
        ///<summary>Bitcoin (BTC) (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/btc/" />
        [Description("Bitcoin (BTC)"), IconId("btc"), IconCategory("Currency Icons"), IconCategory("Brand Icons")]
        Btc = 0xf15a,
        ///<summary>Alias of: Btc</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Btc" />
        [IconAlias]
        Bitcoin = Btc,
        ///<summary>File (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/file/" />
        [Description("File"), IconId("file"), IconCategory("Text Editor Icons"), IconCategory("File Type Icons")]
        File = 0xf15b,
        ///<summary>File Text (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/file-text/" />
        [Description("File Text"), IconId("file-text"), IconCategory("Text Editor Icons"), IconCategory("File Type Icons")]
        FileText = 0xf15c,
        ///<summary>Sort Alpha Ascending (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/sort-alpha-asc/" />
        [Description("Sort Alpha Ascending"), IconId("sort-alpha-asc"), IconCategory("Web Application Icons")]
        SortAlphaAsc = 0xf15d,
        ///<summary>Sort Alpha Descending (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/sort-alpha-desc/" />
        [Description("Sort Alpha Descending"), IconId("sort-alpha-desc"), IconCategory("Web Application Icons")]
        SortAlphaDesc = 0xf15e,
        ///<summary>Sort Amount Ascending (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/sort-amount-asc/" />
        [Description("Sort Amount Ascending"), IconId("sort-amount-asc"), IconCategory("Web Application Icons")]
        SortAmountAsc = 0xf160,
        ///<summary>Sort Amount Descending (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/sort-amount-desc/" />
        [Description("Sort Amount Descending"), IconId("sort-amount-desc"), IconCategory("Web Application Icons")]
        SortAmountDesc = 0xf161,
        ///<summary>Sort Numeric Ascending (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/sort-numeric-asc/" />
        [Description("Sort Numeric Ascending"), IconId("sort-numeric-asc"), IconCategory("Web Application Icons")]
        SortNumericAsc = 0xf162,
        ///<summary>Sort Numeric Descending (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/sort-numeric-desc/" />
        [Description("Sort Numeric Descending"), IconId("sort-numeric-desc"), IconCategory("Web Application Icons")]
        SortNumericDesc = 0xf163,
        ///<summary>thumbs-up (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/thumbs-up/" />
        [Description("thumbs-up"), IconId("thumbs-up"), IconCategory("Web Application Icons"), IconCategory("Hand Icons")]
        ThumbsUp = 0xf164,
        ///<summary>thumbs-down (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/thumbs-down/" />
        [Description("thumbs-down"), IconId("thumbs-down"), IconCategory("Web Application Icons"), IconCategory("Hand Icons")]
        ThumbsDown = 0xf165,
        ///<summary>YouTube Square (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/youtube-square/" />
        [Description("YouTube Square"), IconId("youtube-square"), IconCategory("Brand Icons")]
        YoutubeSquare = 0xf166,
        ///<summary>YouTube (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/youtube/" />
        [Description("YouTube"), IconId("youtube"), IconCategory("Brand Icons")]
        Youtube = 0xf167,
        ///<summary>Xing (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/xing/" />
        [Description("Xing"), IconId("xing"), IconCategory("Brand Icons")]
        Xing = 0xf168,
        ///<summary>Xing Square (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/xing-square/" />
        [Description("Xing Square"), IconId("xing-square"), IconCategory("Brand Icons")]
        XingSquare = 0xf169,
        ///<summary>YouTube Play (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/youtube-play/" />
        [Description("YouTube Play"), IconId("youtube-play"), IconCategory("Brand Icons"), IconCategory("Video Player Icons")]
        YoutubePlay = 0xf16a,
        ///<summary>Dropbox (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/dropbox/" />
        [Description("Dropbox"), IconId("dropbox"), IconCategory("Brand Icons")]
        Dropbox = 0xf16b,
        ///<summary>Stack Overflow (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/stack-overflow/" />
        [Description("Stack Overflow"), IconId("stack-overflow"), IconCategory("Brand Icons")]
        StackOverflow = 0xf16c,
        ///<summary>Instagram (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/instagram/" />
        [Description("Instagram"), IconId("instagram"), IconCategory("Brand Icons")]
        Instagram = 0xf16d,
        ///<summary>Flickr (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/flickr/" />
        [Description("Flickr"), IconId("flickr"), IconCategory("Brand Icons")]
        Flickr = 0xf16e,
        ///<summary>App.net (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/adn/" />
        [Description("App.net"), IconId("adn"), IconCategory("Brand Icons")]
        Adn = 0xf170,
        ///<summary>Bitbucket (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/bitbucket/" />
        [Description("Bitbucket"), IconId("bitbucket"), IconCategory("Brand Icons")]
        Bitbucket = 0xf171,
        ///<summary>Bitbucket Square (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/bitbucket-square/" />
        [Description("Bitbucket Square"), IconId("bitbucket-square"), IconCategory("Brand Icons")]
        BitbucketSquare = 0xf172,
        ///<summary>Tumblr (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/tumblr/" />
        [Description("Tumblr"), IconId("tumblr"), IconCategory("Brand Icons")]
        Tumblr = 0xf173,
        ///<summary>Tumblr Square (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/tumblr-square/" />
        [Description("Tumblr Square"), IconId("tumblr-square"), IconCategory("Brand Icons")]
        TumblrSquare = 0xf174,
        ///<summary>Long Arrow Down (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/long-arrow-down/" />
        [Description("Long Arrow Down"), IconId("long-arrow-down"), IconCategory("Directional Icons")]
        LongArrowDown = 0xf175,
        ///<summary>Long Arrow Up (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/long-arrow-up/" />
        [Description("Long Arrow Up"), IconId("long-arrow-up"), IconCategory("Directional Icons")]
        LongArrowUp = 0xf176,
        ///<summary>Long Arrow Left (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/long-arrow-left/" />
        [Description("Long Arrow Left"), IconId("long-arrow-left"), IconCategory("Directional Icons")]
        LongArrowLeft = 0xf177,
        ///<summary>Long Arrow Right (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/long-arrow-right/" />
        [Description("Long Arrow Right"), IconId("long-arrow-right"), IconCategory("Directional Icons")]
        LongArrowRight = 0xf178,
        ///<summary>Apple (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/apple/" />
        [Description("Apple"), IconId("apple"), IconCategory("Brand Icons")]
        Apple = 0xf179,
        ///<summary>Windows (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/windows/" />
        [Description("Windows"), IconId("windows"), IconCategory("Brand Icons")]
        Windows = 0xf17a,
        ///<summary>Android (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/android/" />
        [Description("Android"), IconId("android"), IconCategory("Brand Icons")]
        Android = 0xf17b,
        ///<summary>Linux (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/linux/" />
        [Description("Linux"), IconId("linux"), IconCategory("Brand Icons")]
        Linux = 0xf17c,
        ///<summary>Dribbble (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/dribbble/" />
        [Description("Dribbble"), IconId("dribbble"), IconCategory("Brand Icons")]
        Dribbble = 0xf17d,
        ///<summary>Skype (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/skype/" />
        [Description("Skype"), IconId("skype"), IconCategory("Brand Icons")]
        Skype = 0xf17e,
        ///<summary>Foursquare (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/foursquare/" />
        [Description("Foursquare"), IconId("foursquare"), IconCategory("Brand Icons")]
        Foursquare = 0xf180,
        ///<summary>Trello (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/trello/" />
        [Description("Trello"), IconId("trello"), IconCategory("Brand Icons")]
        Trello = 0xf181,
        ///<summary>Female (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/female/" />
        [Description("Female"), IconId("female"), IconCategory("Web Application Icons")]
        Female = 0xf182,
        ///<summary>Male (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/male/" />
        [Description("Male"), IconId("male"), IconCategory("Web Application Icons")]
        Male = 0xf183,
        ///<summary>Gratipay (Gittip) (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/gratipay/" />
        [Description("Gratipay (Gittip)"), IconId("gratipay"), IconCategory("Brand Icons")]
        Gratipay = 0xf184,
        ///<summary>Alias of: Gratipay</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Gratipay" />
        [IconAlias]
        Gittip = Gratipay,
        ///<summary>Sun Outlined (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/sun-o/" />
        [Description("Sun Outlined"), IconId("sun-o"), IconCategory("Web Application Icons")]
        SunOutline = 0xf185,
        ///<summary>Moon Outlined (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/moon-o/" />
        [Description("Moon Outlined"), IconId("moon-o"), IconCategory("Web Application Icons")]
        MoonOutline = 0xf186,
        ///<summary>Archive (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/archive/" />
        [Description("Archive"), IconId("archive"), IconCategory("Web Application Icons")]
        Archive = 0xf187,
        ///<summary>Bug (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/bug/" />
        [Description("Bug"), IconId("bug"), IconCategory("Web Application Icons")]
        Bug = 0xf188,
        ///<summary>VK (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/vk/" />
        [Description("VK"), IconId("vk"), IconCategory("Brand Icons")]
        Vk = 0xf189,
        ///<summary>Weibo (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/weibo/" />
        [Description("Weibo"), IconId("weibo"), IconCategory("Brand Icons")]
        Weibo = 0xf18a,
        ///<summary>Renren (created: 3.2)</summary>
        ///<see href="http://fontawesome.io/icon/renren/" />
        [Description("Renren"), IconId("renren"), IconCategory("Brand Icons")]
        Renren = 0xf18b,
        ///<summary>Pagelines (created: 4.0)</summary>
        ///<see href="http://fontawesome.io/icon/pagelines/" />
        [Description("Pagelines"), IconId("pagelines"), IconCategory("Brand Icons")]
        Pagelines = 0xf18c,
        ///<summary>Stack Exchange (created: 4.0)</summary>
        ///<see href="http://fontawesome.io/icon/stack-exchange/" />
        [Description("Stack Exchange"), IconId("stack-exchange"), IconCategory("Brand Icons")]
        StackExchange = 0xf18d,
        ///<summary>Arrow Circle Outlined Right (created: 4.0)</summary>
        ///<see href="http://fontawesome.io/icon/arrow-circle-o-right/" />
        [Description("Arrow Circle Outlined Right"), IconId("arrow-circle-o-right"), IconCategory("Directional Icons")]
        ArrowCircleOutlineRight = 0xf18e,
        ///<summary>Arrow Circle Outlined Left (created: 4.0)</summary>
        ///<see href="http://fontawesome.io/icon/arrow-circle-o-left/" />
        [Description("Arrow Circle Outlined Left"), IconId("arrow-circle-o-left"), IconCategory("Directional Icons")]
        ArrowCircleOutlineLeft = 0xf190,
        ///<summary>Caret Square Outlined Left (created: 4.0)</summary>
        ///<see href="http://fontawesome.io/icon/caret-square-o-left/" />
        [Description("Caret Square Outlined Left"), IconId("caret-square-o-left"), IconCategory("Web Application Icons"), IconCategory("Directional Icons")]
        CaretSquareOutlineLeft = 0xf191,
        ///<summary>Alias of: CaretSquareOutlineLeft</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.CaretSquareOutlineLeft" />
        [IconAlias]
        ToggleLeft = CaretSquareOutlineLeft,
        ///<summary>Dot Circle Outlined (created: 4.0)</summary>
        ///<see href="http://fontawesome.io/icon/dot-circle-o/" />
        [Description("Dot Circle Outlined"), IconId("dot-circle-o"), IconCategory("Web Application Icons"), IconCategory("Form Control Icons")]
        DotCircleOutline = 0xf192,
        ///<summary>Wheelchair (created: 4.0)</summary>
        ///<see href="http://fontawesome.io/icon/wheelchair/" />
        [Description("Wheelchair"), IconId("wheelchair"), IconCategory("Web Application Icons"), IconCategory("Medical Icons"), IconCategory("Transportation Icons"), IconCategory("Accessibility Icons")]
        Wheelchair = 0xf193,
        ///<summary>Vimeo Square (created: 4.0)</summary>
        ///<see href="http://fontawesome.io/icon/vimeo-square/" />
        [Description("Vimeo Square"), IconId("vimeo-square"), IconCategory("Brand Icons")]
        VimeoSquare = 0xf194,
        ///<summary>Turkish Lira (TRY) (created: 4.0)</summary>
        ///<see href="http://fontawesome.io/icon/try/" />
        [Description("Turkish Lira (TRY)"), IconId("try"), IconCategory("Currency Icons")]
        Try = 0xf195,
        ///<summary>Alias of: Try</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Try" />
        [IconAlias]
        TurkishLira = Try,
        ///<summary>Plus Square Outlined (created: 4.0)</summary>
        ///<see href="http://fontawesome.io/icon/plus-square-o/" />
        [Description("Plus Square Outlined"), IconId("plus-square-o"), IconCategory("Web Application Icons"), IconCategory("Form Control Icons")]
        PlusSquareOutline = 0xf196,
        ///<summary>Space Shuttle (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/space-shuttle/" />
        [Description("Space Shuttle"), IconId("space-shuttle"), IconCategory("Web Application Icons"), IconCategory("Transportation Icons")]
        SpaceShuttle = 0xf197,
        ///<summary>Slack Logo (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/slack/" />
        [Description("Slack Logo"), IconId("slack"), IconCategory("Brand Icons")]
        Slack = 0xf198,
        ///<summary>Envelope Square (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/envelope-square/" />
        [Description("Envelope Square"), IconId("envelope-square"), IconCategory("Web Application Icons")]
        EnvelopeSquare = 0xf199,
        ///<summary>WordPress Logo (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/wordpress/" />
        [Description("WordPress Logo"), IconId("wordpress"), IconCategory("Brand Icons")]
        Wordpress = 0xf19a,
        ///<summary>OpenID (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/openid/" />
        [Description("OpenID"), IconId("openid"), IconCategory("Brand Icons")]
        Openid = 0xf19b,
        ///<summary>University (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/university/" />
        [Description("University"), IconId("university"), IconCategory("Web Application Icons")]
        University = 0xf19c,
        ///<summary>Alias of: University</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.University" />
        [IconAlias]
        Institution = University,
        ///<summary>Alias of: University</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.University" />
        [IconAlias]
        Bank = University,
        ///<summary>Graduation Cap (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/graduation-cap/" />
        [Description("Graduation Cap"), IconId("graduation-cap"), IconCategory("Web Application Icons")]
        GraduationCap = 0xf19d,
        ///<summary>Alias of: GraduationCap</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.GraduationCap" />
        [IconAlias]
        MortarBoard = GraduationCap,
        ///<summary>Yahoo Logo (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/yahoo/" />
        [Description("Yahoo Logo"), IconId("yahoo"), IconCategory("Brand Icons")]
        Yahoo = 0xf19e,
        ///<summary>Google Logo (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/google/" />
        [Description("Google Logo"), IconId("google"), IconCategory("Brand Icons")]
        Google = 0xf1a0,
        ///<summary>reddit Logo (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/reddit/" />
        [Description("reddit Logo"), IconId("reddit"), IconCategory("Brand Icons")]
        Reddit = 0xf1a1,
        ///<summary>reddit Square (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/reddit-square/" />
        [Description("reddit Square"), IconId("reddit-square"), IconCategory("Brand Icons")]
        RedditSquare = 0xf1a2,
        ///<summary>StumbleUpon Circle (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/stumbleupon-circle/" />
        [Description("StumbleUpon Circle"), IconId("stumbleupon-circle"), IconCategory("Brand Icons")]
        StumbleuponCircle = 0xf1a3,
        ///<summary>StumbleUpon Logo (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/stumbleupon/" />
        [Description("StumbleUpon Logo"), IconId("stumbleupon"), IconCategory("Brand Icons")]
        Stumbleupon = 0xf1a4,
        ///<summary>Delicious Logo (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/delicious/" />
        [Description("Delicious Logo"), IconId("delicious"), IconCategory("Brand Icons")]
        Delicious = 0xf1a5,
        ///<summary>Digg Logo (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/digg/" />
        [Description("Digg Logo"), IconId("digg"), IconCategory("Brand Icons")]
        Digg = 0xf1a6,
        ///<summary>Pied Piper PP Logo (Old) (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/pied-piper-pp/" />
        [Description("Pied Piper PP Logo (Old)"), IconId("pied-piper-pp"), IconCategory("Brand Icons")]
        PiedPiperPp = 0xf1a7,
        ///<summary>Pied Piper Alternate Logo (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/pied-piper-alt/" />
        [Description("Pied Piper Alternate Logo"), IconId("pied-piper-alt"), IconCategory("Brand Icons")]
        PiedPiperAlt = 0xf1a8,
        ///<summary>Drupal Logo (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/drupal/" />
        [Description("Drupal Logo"), IconId("drupal"), IconCategory("Brand Icons")]
        Drupal = 0xf1a9,
        ///<summary>Joomla Logo (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/joomla/" />
        [Description("Joomla Logo"), IconId("joomla"), IconCategory("Brand Icons")]
        Joomla = 0xf1aa,
        ///<summary>Language (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/language/" />
        [Description("Language"), IconId("language"), IconCategory("Web Application Icons")]
        Language = 0xf1ab,
        ///<summary>Fax (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/fax/" />
        [Description("Fax"), IconId("fax"), IconCategory("Web Application Icons")]
        Fax = 0xf1ac,
        ///<summary>Building (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/building/" />
        [Description("Building"), IconId("building"), IconCategory("Web Application Icons")]
        Building = 0xf1ad,
        ///<summary>Child (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/child/" />
        [Description("Child"), IconId("child"), IconCategory("Web Application Icons")]
        Child = 0xf1ae,
        ///<summary>Paw (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/paw/" />
        [Description("Paw"), IconId("paw"), IconCategory("Web Application Icons")]
        Paw = 0xf1b0,
        ///<summary>spoon (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/spoon/" />
        [Description("spoon"), IconId("spoon"), IconCategory("Web Application Icons")]
        Spoon = 0xf1b1,
        ///<summary>Cube (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/cube/" />
        [Description("Cube"), IconId("cube"), IconCategory("Web Application Icons")]
        Cube = 0xf1b2,
        ///<summary>Cubes (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/cubes/" />
        [Description("Cubes"), IconId("cubes"), IconCategory("Web Application Icons")]
        Cubes = 0xf1b3,
        ///<summary>Behance (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/behance/" />
        [Description("Behance"), IconId("behance"), IconCategory("Brand Icons")]
        Behance = 0xf1b4,
        ///<summary>Behance Square (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/behance-square/" />
        [Description("Behance Square"), IconId("behance-square"), IconCategory("Brand Icons")]
        BehanceSquare = 0xf1b5,
        ///<summary>Steam (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/steam/" />
        [Description("Steam"), IconId("steam"), IconCategory("Brand Icons")]
        Steam = 0xf1b6,
        ///<summary>Steam Square (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/steam-square/" />
        [Description("Steam Square"), IconId("steam-square"), IconCategory("Brand Icons")]
        SteamSquare = 0xf1b7,
        ///<summary>Recycle (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/recycle/" />
        [Description("Recycle"), IconId("recycle"), IconCategory("Web Application Icons")]
        Recycle = 0xf1b8,
        ///<summary>Car (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/car/" />
        [Description("Car"), IconId("car"), IconCategory("Web Application Icons"), IconCategory("Transportation Icons")]
        Car = 0xf1b9,
        ///<summary>Alias of: Car</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Car" />
        [IconAlias]
        Automobile = Car,
        ///<summary>Taxi (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/taxi/" />
        [Description("Taxi"), IconId("taxi"), IconCategory("Web Application Icons"), IconCategory("Transportation Icons")]
        Taxi = 0xf1ba,
        ///<summary>Alias of: Taxi</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Taxi" />
        [IconAlias]
        Cab = Taxi,
        ///<summary>Tree (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/tree/" />
        [Description("Tree"), IconId("tree"), IconCategory("Web Application Icons")]
        Tree = 0xf1bb,
        ///<summary>Spotify (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/spotify/" />
        [Description("Spotify"), IconId("spotify"), IconCategory("Brand Icons")]
        Spotify = 0xf1bc,
        ///<summary>deviantART (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/deviantart/" />
        [Description("deviantART"), IconId("deviantart"), IconCategory("Brand Icons")]
        Deviantart = 0xf1bd,
        ///<summary>SoundCloud (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/soundcloud/" />
        [Description("SoundCloud"), IconId("soundcloud"), IconCategory("Brand Icons")]
        Soundcloud = 0xf1be,
        ///<summary>Database (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/database/" />
        [Description("Database"), IconId("database"), IconCategory("Web Application Icons")]
        Database = 0xf1c0,
        ///<summary>PDF File Outlined (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/file-pdf-o/" />
        [Description("PDF File Outlined"), IconId("file-pdf-o"), IconCategory("Web Application Icons"), IconCategory("File Type Icons")]
        FilePdfOutline = 0xf1c1,
        ///<summary>Word File Outlined (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/file-word-o/" />
        [Description("Word File Outlined"), IconId("file-word-o"), IconCategory("Web Application Icons"), IconCategory("File Type Icons")]
        FileWordOutline = 0xf1c2,
        ///<summary>Excel File Outlined (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/file-excel-o/" />
        [Description("Excel File Outlined"), IconId("file-excel-o"), IconCategory("Web Application Icons"), IconCategory("File Type Icons")]
        FileExcelOutline = 0xf1c3,
        ///<summary>Powerpoint File Outlined (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/file-powerpoint-o/" />
        [Description("Powerpoint File Outlined"), IconId("file-powerpoint-o"), IconCategory("Web Application Icons"), IconCategory("File Type Icons")]
        FilePowerpointOutline = 0xf1c4,
        ///<summary>Image File Outlined (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/file-image-o/" />
        [Description("Image File Outlined"), IconId("file-image-o"), IconCategory("Web Application Icons"), IconCategory("File Type Icons")]
        FileImageOutline = 0xf1c5,
        ///<summary>Alias of: FileImageOutline</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.FileImageOutline" />
        [IconAlias]
        FilePhotoOutline = FileImageOutline,
        ///<summary>Alias of: FileImageOutline</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.FileImageOutline" />
        [IconAlias]
        FilePictureOutline = FileImageOutline,
        ///<summary>Archive File Outlined (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/file-archive-o/" />
        [Description("Archive File Outlined"), IconId("file-archive-o"), IconCategory("Web Application Icons"), IconCategory("File Type Icons")]
        FileArchiveOutline = 0xf1c6,
        ///<summary>Alias of: FileArchiveOutline</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.FileArchiveOutline" />
        [IconAlias]
        FileZipOutline = FileArchiveOutline,
        ///<summary>Audio File Outlined (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/file-audio-o/" />
        [Description("Audio File Outlined"), IconId("file-audio-o"), IconCategory("Web Application Icons"), IconCategory("File Type Icons")]
        FileAudioOutline = 0xf1c7,
        ///<summary>Alias of: FileAudioOutline</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.FileAudioOutline" />
        [IconAlias]
        FileSoundOutline = FileAudioOutline,
        ///<summary>Video File Outlined (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/file-video-o/" />
        [Description("Video File Outlined"), IconId("file-video-o"), IconCategory("Web Application Icons"), IconCategory("File Type Icons")]
        FileVideoOutline = 0xf1c8,
        ///<summary>Alias of: FileVideoOutline</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.FileVideoOutline" />
        [IconAlias]
        FileMovieOutline = FileVideoOutline,
        ///<summary>Code File Outlined (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/file-code-o/" />
        [Description("Code File Outlined"), IconId("file-code-o"), IconCategory("Web Application Icons"), IconCategory("File Type Icons")]
        FileCodeOutline = 0xf1c9,
        ///<summary>Vine (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/vine/" />
        [Description("Vine"), IconId("vine"), IconCategory("Brand Icons")]
        Vine = 0xf1ca,
        ///<summary>Codepen (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/codepen/" />
        [Description("Codepen"), IconId("codepen"), IconCategory("Brand Icons")]
        Codepen = 0xf1cb,
        ///<summary>jsFiddle (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/jsfiddle/" />
        [Description("jsFiddle"), IconId("jsfiddle"), IconCategory("Brand Icons")]
        Jsfiddle = 0xf1cc,
        ///<summary>Life Ring (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/life-ring/" />
        [Description("Life Ring"), IconId("life-ring"), IconCategory("Web Application Icons")]
        LifeRing = 0xf1cd,
        ///<summary>Alias of: LifeRing</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.LifeRing" />
        [IconAlias]
        LifeBouy = LifeRing,
        ///<summary>Alias of: LifeRing</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.LifeRing" />
        [IconAlias]
        LifeBuoy = LifeRing,
        ///<summary>Alias of: LifeRing</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.LifeRing" />
        [IconAlias]
        LifeSaver = LifeRing,
        ///<summary>Alias of: LifeRing</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.LifeRing" />
        [IconAlias]
        Support = LifeRing,
        ///<summary>Circle Outlined Notched (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/circle-o-notch/" />
        [Description("Circle Outlined Notched"), IconId("circle-o-notch"), IconCategory("Web Application Icons"), IconCategory("Spinner Icons")]
        CircleOutlineNotch = 0xf1ce,
        ///<summary>Rebel Alliance (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/rebel/" />
        [Description("Rebel Alliance"), IconId("rebel"), IconCategory("Brand Icons")]
        Rebel = 0xf1d0,
        ///<summary>Alias of: Rebel</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Rebel" />
        [IconAlias]
        Ra = Rebel,
        ///<summary>Alias of: Rebel</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Rebel" />
        [IconAlias]
        Resistance = Rebel,
        ///<summary>Galactic Empire (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/empire/" />
        [Description("Galactic Empire"), IconId("empire"), IconCategory("Brand Icons")]
        Empire = 0xf1d1,
        ///<summary>Alias of: Empire</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Empire" />
        [IconAlias]
        Ge = Empire,
        ///<summary>Git Square (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/git-square/" />
        [Description("Git Square"), IconId("git-square"), IconCategory("Brand Icons")]
        GitSquare = 0xf1d2,
        ///<summary>Git (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/git/" />
        [Description("Git"), IconId("git"), IconCategory("Brand Icons")]
        Git = 0xf1d3,
        ///<summary>Hacker News (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/hacker-news/" />
        [Description("Hacker News"), IconId("hacker-news"), IconCategory("Brand Icons")]
        HackerNews = 0xf1d4,
        ///<summary>Alias of: HackerNews</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.HackerNews" />
        [IconAlias]
        YCombinatorSquare = HackerNews,
        ///<summary>Alias of: HackerNews</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.HackerNews" />
        [IconAlias]
        YcSquare = HackerNews,
        ///<summary>Tencent Weibo (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/tencent-weibo/" />
        [Description("Tencent Weibo"), IconId("tencent-weibo"), IconCategory("Brand Icons")]
        TencentWeibo = 0xf1d5,
        ///<summary>QQ (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/qq/" />
        [Description("QQ"), IconId("qq"), IconCategory("Brand Icons")]
        Qq = 0xf1d6,
        ///<summary>Weixin (WeChat) (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/weixin/" />
        [Description("Weixin (WeChat)"), IconId("weixin"), IconCategory("Brand Icons")]
        Weixin = 0xf1d7,
        ///<summary>Alias of: Weixin</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Weixin" />
        [IconAlias]
        Wechat = Weixin,
        ///<summary>Paper Plane (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/paper-plane/" />
        [Description("Paper Plane"), IconId("paper-plane"), IconCategory("Web Application Icons")]
        PaperPlane = 0xf1d8,
        ///<summary>Alias of: PaperPlane</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.PaperPlane" />
        [IconAlias]
        Send = PaperPlane,
        ///<summary>Paper Plane Outlined (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/paper-plane-o/" />
        [Description("Paper Plane Outlined"), IconId("paper-plane-o"), IconCategory("Web Application Icons")]
        PaperPlaneOutline = 0xf1d9,
        ///<summary>Alias of: PaperPlaneOutline</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.PaperPlaneOutline" />
        [IconAlias]
        SendOutline = PaperPlaneOutline,
        ///<summary>History (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/history/" />
        [Description("History"), IconId("history"), IconCategory("Web Application Icons")]
        History = 0xf1da,
        ///<summary>Circle Outlined Thin (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/circle-thin/" />
        [Description("Circle Outlined Thin"), IconId("circle-thin"), IconCategory("Web Application Icons")]
        CircleThin = 0xf1db,
        ///<summary>header (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/header/" />
        [Description("header"), IconId("header"), IconCategory("Text Editor Icons")]
        Header = 0xf1dc,
        ///<summary>paragraph (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/paragraph/" />
        [Description("paragraph"), IconId("paragraph"), IconCategory("Text Editor Icons")]
        Paragraph = 0xf1dd,
        ///<summary>Sliders (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/sliders/" />
        [Description("Sliders"), IconId("sliders"), IconCategory("Web Application Icons")]
        Sliders = 0xf1de,
        ///<summary>Share Alt (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/share-alt/" />
        [Description("Share Alt"), IconId("share-alt"), IconCategory("Web Application Icons"), IconCategory("Brand Icons")]
        ShareAlt = 0xf1e0,
        ///<summary>Share Alt Square (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/share-alt-square/" />
        [Description("Share Alt Square"), IconId("share-alt-square"), IconCategory("Web Application Icons"), IconCategory("Brand Icons")]
        ShareAltSquare = 0xf1e1,
        ///<summary>Bomb (created: 4.1)</summary>
        ///<see href="http://fontawesome.io/icon/bomb/" />
        [Description("Bomb"), IconId("bomb"), IconCategory("Web Application Icons")]
        Bomb = 0xf1e2,
        ///<summary>Futbol Outlined (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/futbol-o/" />
        [Description("Futbol Outlined"), IconId("futbol-o"), IconCategory("Web Application Icons")]
        FutbolOutline = 0xf1e3,
        ///<summary>Alias of: FutbolOutline</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.FutbolOutline" />
        [IconAlias]
        SoccerBallOutline = FutbolOutline,
        ///<summary>TTY (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/tty/" />
        [Description("TTY"), IconId("tty"), IconCategory("Web Application Icons"), IconCategory("Accessibility Icons")]
        Tty = 0xf1e4,
        ///<summary>Binoculars (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/binoculars/" />
        [Description("Binoculars"), IconId("binoculars"), IconCategory("Web Application Icons")]
        Binoculars = 0xf1e5,
        ///<summary>Plug (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/plug/" />
        [Description("Plug"), IconId("plug"), IconCategory("Web Application Icons")]
        Plug = 0xf1e6,
        ///<summary>Slideshare (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/slideshare/" />
        [Description("Slideshare"), IconId("slideshare"), IconCategory("Brand Icons")]
        Slideshare = 0xf1e7,
        ///<summary>Twitch (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/twitch/" />
        [Description("Twitch"), IconId("twitch"), IconCategory("Brand Icons")]
        Twitch = 0xf1e8,
        ///<summary>Yelp (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/yelp/" />
        [Description("Yelp"), IconId("yelp"), IconCategory("Brand Icons")]
        Yelp = 0xf1e9,
        ///<summary>Newspaper Outlined (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/newspaper-o/" />
        [Description("Newspaper Outlined"), IconId("newspaper-o"), IconCategory("Web Application Icons")]
        NewspaperOutline = 0xf1ea,
        ///<summary>WiFi (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/wifi/" />
        [Description("WiFi"), IconId("wifi"), IconCategory("Web Application Icons")]
        Wifi = 0xf1eb,
        ///<summary>Calculator (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/calculator/" />
        [Description("Calculator"), IconId("calculator"), IconCategory("Web Application Icons")]
        Calculator = 0xf1ec,
        ///<summary>Paypal (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/paypal/" />
        [Description("Paypal"), IconId("paypal"), IconCategory("Brand Icons"), IconCategory("Payment Icons")]
        Paypal = 0xf1ed,
        ///<summary>Google Wallet (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/google-wallet/" />
        [Description("Google Wallet"), IconId("google-wallet"), IconCategory("Brand Icons"), IconCategory("Payment Icons")]
        GoogleWallet = 0xf1ee,
        ///<summary>Visa Credit Card (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/cc-visa/" />
        [Description("Visa Credit Card"), IconId("cc-visa"), IconCategory("Brand Icons"), IconCategory("Payment Icons")]
        CcVisa = 0xf1f0,
        ///<summary>MasterCard Credit Card (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/cc-mastercard/" />
        [Description("MasterCard Credit Card"), IconId("cc-mastercard"), IconCategory("Brand Icons"), IconCategory("Payment Icons")]
        CcMastercard = 0xf1f1,
        ///<summary>Discover Credit Card (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/cc-discover/" />
        [Description("Discover Credit Card"), IconId("cc-discover"), IconCategory("Brand Icons"), IconCategory("Payment Icons")]
        CcDiscover = 0xf1f2,
        ///<summary>American Express Credit Card (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/cc-amex/" />
        [Description("American Express Credit Card"), IconId("cc-amex"), IconCategory("Brand Icons"), IconCategory("Payment Icons")]
        CcAmex = 0xf1f3,
        ///<summary>Paypal Credit Card (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/cc-paypal/" />
        [Description("Paypal Credit Card"), IconId("cc-paypal"), IconCategory("Brand Icons"), IconCategory("Payment Icons")]
        CcPaypal = 0xf1f4,
        ///<summary>Stripe Credit Card (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/cc-stripe/" />
        [Description("Stripe Credit Card"), IconId("cc-stripe"), IconCategory("Brand Icons"), IconCategory("Payment Icons")]
        CcStripe = 0xf1f5,
        ///<summary>Bell Slash (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/bell-slash/" />
        [Description("Bell Slash"), IconId("bell-slash"), IconCategory("Web Application Icons")]
        BellSlash = 0xf1f6,
        ///<summary>Bell Slash Outlined (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/bell-slash-o/" />
        [Description("Bell Slash Outlined"), IconId("bell-slash-o"), IconCategory("Web Application Icons")]
        BellSlashOutline = 0xf1f7,
        ///<summary>Trash (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/trash/" />
        [Description("Trash"), IconId("trash"), IconCategory("Web Application Icons")]
        Trash = 0xf1f8,
        ///<summary>Copyright (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/copyright/" />
        [Description("Copyright"), IconId("copyright"), IconCategory("Web Application Icons")]
        Copyright = 0xf1f9,
        ///<summary>At (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/at/" />
        [Description("At"), IconId("at"), IconCategory("Web Application Icons")]
        At = 0xf1fa,
        ///<summary>Eyedropper (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/eyedropper/" />
        [Description("Eyedropper"), IconId("eyedropper"), IconCategory("Web Application Icons")]
        Eyedropper = 0xf1fb,
        ///<summary>Paint Brush (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/paint-brush/" />
        [Description("Paint Brush"), IconId("paint-brush"), IconCategory("Web Application Icons")]
        PaintBrush = 0xf1fc,
        ///<summary>Birthday Cake (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/birthday-cake/" />
        [Description("Birthday Cake"), IconId("birthday-cake"), IconCategory("Web Application Icons")]
        BirthdayCake = 0xf1fd,
        ///<summary>Area Chart (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/area-chart/" />
        [Description("Area Chart"), IconId("area-chart"), IconCategory("Web Application Icons"), IconCategory("Chart Icons")]
        AreaChart = 0xf1fe,
        ///<summary>Pie Chart (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/pie-chart/" />
        [Description("Pie Chart"), IconId("pie-chart"), IconCategory("Web Application Icons"), IconCategory("Chart Icons")]
        PieChart = 0xf200,
        ///<summary>Line Chart (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/line-chart/" />
        [Description("Line Chart"), IconId("line-chart"), IconCategory("Web Application Icons"), IconCategory("Chart Icons")]
        LineChart = 0xf201,
        ///<summary>last.fm (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/lastfm/" />
        [Description("last.fm"), IconId("lastfm"), IconCategory("Brand Icons")]
        Lastfm = 0xf202,
        ///<summary>last.fm Square (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/lastfm-square/" />
        [Description("last.fm Square"), IconId("lastfm-square"), IconCategory("Brand Icons")]
        LastfmSquare = 0xf203,
        ///<summary>Toggle Off (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/toggle-off/" />
        [Description("Toggle Off"), IconId("toggle-off"), IconCategory("Web Application Icons")]
        ToggleOff = 0xf204,
        ///<summary>Toggle On (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/toggle-on/" />
        [Description("Toggle On"), IconId("toggle-on"), IconCategory("Web Application Icons")]
        ToggleOn = 0xf205,
        ///<summary>Bicycle (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/bicycle/" />
        [Description("Bicycle"), IconId("bicycle"), IconCategory("Web Application Icons"), IconCategory("Transportation Icons")]
        Bicycle = 0xf206,
        ///<summary>Bus (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/bus/" />
        [Description("Bus"), IconId("bus"), IconCategory("Web Application Icons"), IconCategory("Transportation Icons")]
        Bus = 0xf207,
        ///<summary>ioxhost (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/ioxhost/" />
        [Description("ioxhost"), IconId("ioxhost"), IconCategory("Brand Icons")]
        Ioxhost = 0xf208,
        ///<summary>AngelList (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/angellist/" />
        [Description("AngelList"), IconId("angellist"), IconCategory("Brand Icons")]
        Angellist = 0xf209,
        ///<summary>Closed Captions (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/cc/" />
        [Description("Closed Captions"), IconId("cc"), IconCategory("Web Application Icons"), IconCategory("Accessibility Icons")]
        Cc = 0xf20a,
        ///<summary>Shekel (ILS) (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/ils/" />
        [Description("Shekel (ILS)"), IconId("ils"), IconCategory("Currency Icons")]
        Ils = 0xf20b,
        ///<summary>Alias of: Ils</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Ils" />
        [IconAlias]
        Shekel = Ils,
        ///<summary>Alias of: Ils</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Ils" />
        [IconAlias]
        Sheqel = Ils,
        ///<summary>meanpath (created: 4.2)</summary>
        ///<see href="http://fontawesome.io/icon/meanpath/" />
        [Description("meanpath"), IconId("meanpath"), IconCategory("Brand Icons")]
        Meanpath = 0xf20c,
        ///<summary>BuySellAds (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/buysellads/" />
        [Description("BuySellAds"), IconId("buysellads"), IconCategory("Brand Icons")]
        Buysellads = 0xf20d,
        ///<summary>Connect Develop (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/connectdevelop/" />
        [Description("Connect Develop"), IconId("connectdevelop"), IconCategory("Brand Icons")]
        Connectdevelop = 0xf20e,
        ///<summary>DashCube (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/dashcube/" />
        [Description("DashCube"), IconId("dashcube"), IconCategory("Brand Icons")]
        Dashcube = 0xf210,
        ///<summary>Forumbee (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/forumbee/" />
        [Description("Forumbee"), IconId("forumbee"), IconCategory("Brand Icons")]
        Forumbee = 0xf211,
        ///<summary>Leanpub (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/leanpub/" />
        [Description("Leanpub"), IconId("leanpub"), IconCategory("Brand Icons")]
        Leanpub = 0xf212,
        ///<summary>Sellsy (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/sellsy/" />
        [Description("Sellsy"), IconId("sellsy"), IconCategory("Brand Icons")]
        Sellsy = 0xf213,
        ///<summary>Shirts in Bulk (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/shirtsinbulk/" />
        [Description("Shirts in Bulk"), IconId("shirtsinbulk"), IconCategory("Brand Icons")]
        Shirtsinbulk = 0xf214,
        ///<summary>SimplyBuilt (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/simplybuilt/" />
        [Description("SimplyBuilt"), IconId("simplybuilt"), IconCategory("Brand Icons")]
        Simplybuilt = 0xf215,
        ///<summary>skyatlas (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/skyatlas/" />
        [Description("skyatlas"), IconId("skyatlas"), IconCategory("Brand Icons")]
        Skyatlas = 0xf216,
        ///<summary>Add to Shopping Cart (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/cart-plus/" />
        [Description("Add to Shopping Cart"), IconId("cart-plus"), IconCategory("Web Application Icons")]
        CartPlus = 0xf217,
        ///<summary>Shopping Cart Arrow Down (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/cart-arrow-down/" />
        [Description("Shopping Cart Arrow Down"), IconId("cart-arrow-down"), IconCategory("Web Application Icons")]
        CartArrowDown = 0xf218,
        ///<summary>Diamond (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/diamond/" />
        [Description("Diamond"), IconId("diamond"), IconCategory("Web Application Icons")]
        Diamond = 0xf219,
        ///<summary>Ship (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/ship/" />
        [Description("Ship"), IconId("ship"), IconCategory("Web Application Icons"), IconCategory("Transportation Icons")]
        Ship = 0xf21a,
        ///<summary>User Secret (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/user-secret/" />
        [Description("User Secret"), IconId("user-secret"), IconCategory("Web Application Icons")]
        UserSecret = 0xf21b,
        ///<summary>Motorcycle (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/motorcycle/" />
        [Description("Motorcycle"), IconId("motorcycle"), IconCategory("Web Application Icons"), IconCategory("Transportation Icons")]
        Motorcycle = 0xf21c,
        ///<summary>Street View (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/street-view/" />
        [Description("Street View"), IconId("street-view"), IconCategory("Web Application Icons")]
        StreetView = 0xf21d,
        ///<summary>Heartbeat (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/heartbeat/" />
        [Description("Heartbeat"), IconId("heartbeat"), IconCategory("Web Application Icons"), IconCategory("Medical Icons")]
        Heartbeat = 0xf21e,
        ///<summary>Venus (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/venus/" />
        [Description("Venus"), IconId("venus"), IconCategory("Gender Icons")]
        Venus = 0xf221,
        ///<summary>Mars (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/mars/" />
        [Description("Mars"), IconId("mars"), IconCategory("Gender Icons")]
        Mars = 0xf222,
        ///<summary>Mercury (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/mercury/" />
        [Description("Mercury"), IconId("mercury"), IconCategory("Gender Icons")]
        Mercury = 0xf223,
        ///<summary>Transgender (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/transgender/" />
        [Description("Transgender"), IconId("transgender"), IconCategory("Gender Icons")]
        Transgender = 0xf224,
        ///<summary>Alias of: Transgender</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Transgender" />
        [IconAlias]
        Intersex = Transgender,
        ///<summary>Transgender Alt (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/transgender-alt/" />
        [Description("Transgender Alt"), IconId("transgender-alt"), IconCategory("Gender Icons")]
        TransgenderAlt = 0xf225,
        ///<summary>Venus Double (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/venus-double/" />
        [Description("Venus Double"), IconId("venus-double"), IconCategory("Gender Icons")]
        VenusDouble = 0xf226,
        ///<summary>Mars Double (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/mars-double/" />
        [Description("Mars Double"), IconId("mars-double"), IconCategory("Gender Icons")]
        MarsDouble = 0xf227,
        ///<summary>Venus Mars (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/venus-mars/" />
        [Description("Venus Mars"), IconId("venus-mars"), IconCategory("Gender Icons")]
        VenusMars = 0xf228,
        ///<summary>Mars Stroke (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/mars-stroke/" />
        [Description("Mars Stroke"), IconId("mars-stroke"), IconCategory("Gender Icons")]
        MarsStroke = 0xf229,
        ///<summary>Mars Stroke Vertical (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/mars-stroke-v/" />
        [Description("Mars Stroke Vertical"), IconId("mars-stroke-v"), IconCategory("Gender Icons")]
        MarsStrokeV = 0xf22a,
        ///<summary>Mars Stroke Horizontal (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/mars-stroke-h/" />
        [Description("Mars Stroke Horizontal"), IconId("mars-stroke-h"), IconCategory("Gender Icons")]
        MarsStrokeH = 0xf22b,
        ///<summary>Neuter (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/neuter/" />
        [Description("Neuter"), IconId("neuter"), IconCategory("Gender Icons")]
        Neuter = 0xf22c,
        ///<summary>Genderless (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/genderless/" />
        [Description("Genderless"), IconId("genderless"), IconCategory("Gender Icons")]
        Genderless = 0xf22d,
        ///<summary>Facebook Official (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/facebook-official/" />
        [Description("Facebook Official"), IconId("facebook-official"), IconCategory("Brand Icons")]
        FacebookOfficial = 0xf230,
        ///<summary>Pinterest P (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/pinterest-p/" />
        [Description("Pinterest P"), IconId("pinterest-p"), IconCategory("Brand Icons")]
        PinterestP = 0xf231,
        ///<summary>What's App (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/whatsapp/" />
        [Description("What's App"), IconId("whatsapp"), IconCategory("Brand Icons")]
        Whatsapp = 0xf232,
        ///<summary>Server (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/server/" />
        [Description("Server"), IconId("server"), IconCategory("Web Application Icons")]
        Server = 0xf233,
        ///<summary>Add User (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/user-plus/" />
        [Description("Add User"), IconId("user-plus"), IconCategory("Web Application Icons")]
        UserPlus = 0xf234,
        ///<summary>Remove User (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/user-times/" />
        [Description("Remove User"), IconId("user-times"), IconCategory("Web Application Icons")]
        UserTimes = 0xf235,
        ///<summary>Bed (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/bed/" />
        [Description("Bed"), IconId("bed"), IconCategory("Web Application Icons")]
        Bed = 0xf236,
        ///<summary>Alias of: Bed</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Bed" />
        [IconAlias]
        Hotel = Bed,
        ///<summary>Viacoin (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/viacoin/" />
        [Description("Viacoin"), IconId("viacoin"), IconCategory("Brand Icons")]
        Viacoin = 0xf237,
        ///<summary>Train (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/train/" />
        [Description("Train"), IconId("train"), IconCategory("Transportation Icons")]
        Train = 0xf238,
        ///<summary>Subway (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/subway/" />
        [Description("Subway"), IconId("subway"), IconCategory("Transportation Icons")]
        Subway = 0xf239,
        ///<summary>Medium (created: 4.3)</summary>
        ///<see href="http://fontawesome.io/icon/medium/" />
        [Description("Medium"), IconId("medium"), IconCategory("Brand Icons")]
        Medium = 0xf23a,
        ///<summary>Y Combinator (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/y-combinator/" />
        [Description("Y Combinator"), IconId("y-combinator"), IconCategory("Brand Icons")]
        YCombinator = 0xf23b,
        ///<summary>Alias of: YCombinator</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.YCombinator" />
        [IconAlias]
        Yc = YCombinator,
        ///<summary>Optin Monster (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/optin-monster/" />
        [Description("Optin Monster"), IconId("optin-monster"), IconCategory("Brand Icons")]
        OptinMonster = 0xf23c,
        ///<summary>OpenCart (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/opencart/" />
        [Description("OpenCart"), IconId("opencart"), IconCategory("Brand Icons")]
        Opencart = 0xf23d,
        ///<summary>ExpeditedSSL (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/expeditedssl/" />
        [Description("ExpeditedSSL"), IconId("expeditedssl"), IconCategory("Brand Icons")]
        Expeditedssl = 0xf23e,
        ///<summary>Battery Full (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/battery-full/" />
        [Description("Battery Full"), IconId("battery-full"), IconCategory("Web Application Icons")]
        BatteryFull = 0xf240,
        ///<summary>Alias of: BatteryFull</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.BatteryFull" />
        [IconAlias]
        Battery4 = BatteryFull,
        ///<summary>Alias of: BatteryFull</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.BatteryFull" />
        [IconAlias]
        Battery = BatteryFull,
        ///<summary>Battery 3/4 Full (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/battery-three-quarters/" />
        [Description("Battery 3/4 Full"), IconId("battery-three-quarters"), IconCategory("Web Application Icons")]
        BatteryThreeQuarters = 0xf241,
        ///<summary>Alias of: BatteryThreeQuarters</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.BatteryThreeQuarters" />
        [IconAlias]
        Battery3 = BatteryThreeQuarters,
        ///<summary>Battery 1/2 Full (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/battery-half/" />
        [Description("Battery 1/2 Full"), IconId("battery-half"), IconCategory("Web Application Icons")]
        BatteryHalf = 0xf242,
        ///<summary>Alias of: BatteryHalf</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.BatteryHalf" />
        [IconAlias]
        Battery2 = BatteryHalf,
        ///<summary>Battery 1/4 Full (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/battery-quarter/" />
        [Description("Battery 1/4 Full"), IconId("battery-quarter"), IconCategory("Web Application Icons")]
        BatteryQuarter = 0xf243,
        ///<summary>Alias of: BatteryQuarter</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.BatteryQuarter" />
        [IconAlias]
        Battery1 = BatteryQuarter,
        ///<summary>Battery Empty (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/battery-empty/" />
        [Description("Battery Empty"), IconId("battery-empty"), IconCategory("Web Application Icons")]
        BatteryEmpty = 0xf244,
        ///<summary>Alias of: BatteryEmpty</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.BatteryEmpty" />
        [IconAlias]
        Battery0 = BatteryEmpty,
        ///<summary>Mouse Pointer (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/mouse-pointer/" />
        [Description("Mouse Pointer"), IconId("mouse-pointer"), IconCategory("Web Application Icons")]
        MousePointer = 0xf245,
        ///<summary>I Beam Cursor (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/i-cursor/" />
        [Description("I Beam Cursor"), IconId("i-cursor"), IconCategory("Web Application Icons")]
        ICursor = 0xf246,
        ///<summary>Object Group (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/object-group/" />
        [Description("Object Group"), IconId("object-group"), IconCategory("Web Application Icons")]
        ObjectGroup = 0xf247,
        ///<summary>Object Ungroup (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/object-ungroup/" />
        [Description("Object Ungroup"), IconId("object-ungroup"), IconCategory("Web Application Icons")]
        ObjectUngroup = 0xf248,
        ///<summary>Sticky Note (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/sticky-note/" />
        [Description("Sticky Note"), IconId("sticky-note"), IconCategory("Web Application Icons")]
        StickyNote = 0xf249,
        ///<summary>Sticky Note Outlined (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/sticky-note-o/" />
        [Description("Sticky Note Outlined"), IconId("sticky-note-o"), IconCategory("Web Application Icons")]
        StickyNoteOutline = 0xf24a,
        ///<summary>JCB Credit Card (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/cc-jcb/" />
        [Description("JCB Credit Card"), IconId("cc-jcb"), IconCategory("Brand Icons"), IconCategory("Payment Icons")]
        CcJcb = 0xf24b,
        ///<summary>Diner's Club Credit Card (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/cc-diners-club/" />
        [Description("Diner's Club Credit Card"), IconId("cc-diners-club"), IconCategory("Brand Icons"), IconCategory("Payment Icons")]
        CcDinersClub = 0xf24c,
        ///<summary>Clone (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/clone/" />
        [Description("Clone"), IconId("clone"), IconCategory("Web Application Icons")]
        Clone = 0xf24d,
        ///<summary>Balance Scale (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/balance-scale/" />
        [Description("Balance Scale"), IconId("balance-scale"), IconCategory("Web Application Icons")]
        BalanceScale = 0xf24e,
        ///<summary>Hourglass Outlined (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/hourglass-o/" />
        [Description("Hourglass Outlined"), IconId("hourglass-o"), IconCategory("Web Application Icons")]
        HourglassOutline = 0xf250,
        ///<summary>Hourglass Start (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/hourglass-start/" />
        [Description("Hourglass Start"), IconId("hourglass-start"), IconCategory("Web Application Icons")]
        HourglassStart = 0xf251,
        ///<summary>Alias of: HourglassStart</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.HourglassStart" />
        [IconAlias]
        Hourglass1 = HourglassStart,
        ///<summary>Hourglass Half (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/hourglass-half/" />
        [Description("Hourglass Half"), IconId("hourglass-half"), IconCategory("Web Application Icons")]
        HourglassHalf = 0xf252,
        ///<summary>Alias of: HourglassHalf</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.HourglassHalf" />
        [IconAlias]
        Hourglass2 = HourglassHalf,
        ///<summary>Hourglass End (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/hourglass-end/" />
        [Description("Hourglass End"), IconId("hourglass-end"), IconCategory("Web Application Icons")]
        HourglassEnd = 0xf253,
        ///<summary>Alias of: HourglassEnd</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.HourglassEnd" />
        [IconAlias]
        Hourglass3 = HourglassEnd,
        ///<summary>Hourglass (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/hourglass/" />
        [Description("Hourglass"), IconId("hourglass"), IconCategory("Web Application Icons")]
        Hourglass = 0xf254,
        ///<summary>Rock (Hand) (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/hand-rock-o/" />
        [Description("Rock (Hand)"), IconId("hand-rock-o"), IconCategory("Web Application Icons"), IconCategory("Hand Icons")]
        HandRockOutline = 0xf255,
        ///<summary>Alias of: HandRockOutline</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.HandRockOutline" />
        [IconAlias]
        HandGrabOutline = HandRockOutline,
        ///<summary>Paper (Hand) (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/hand-paper-o/" />
        [Description("Paper (Hand)"), IconId("hand-paper-o"), IconCategory("Web Application Icons"), IconCategory("Hand Icons")]
        HandPaperOutline = 0xf256,
        ///<summary>Alias of: HandPaperOutline</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.HandPaperOutline" />
        [IconAlias]
        HandStopOutline = HandPaperOutline,
        ///<summary>Scissors (Hand) (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/hand-scissors-o/" />
        [Description("Scissors (Hand)"), IconId("hand-scissors-o"), IconCategory("Web Application Icons"), IconCategory("Hand Icons")]
        HandScissorsOutline = 0xf257,
        ///<summary>Lizard (Hand) (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/hand-lizard-o/" />
        [Description("Lizard (Hand)"), IconId("hand-lizard-o"), IconCategory("Web Application Icons"), IconCategory("Hand Icons")]
        HandLizardOutline = 0xf258,
        ///<summary>Spock (Hand) (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/hand-spock-o/" />
        [Description("Spock (Hand)"), IconId("hand-spock-o"), IconCategory("Web Application Icons"), IconCategory("Hand Icons")]
        HandSpockOutline = 0xf259,
        ///<summary>Hand Pointer (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/hand-pointer-o/" />
        [Description("Hand Pointer"), IconId("hand-pointer-o"), IconCategory("Web Application Icons"), IconCategory("Hand Icons")]
        HandPointerOutline = 0xf25a,
        ///<summary>Hand Peace (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/hand-peace-o/" />
        [Description("Hand Peace"), IconId("hand-peace-o"), IconCategory("Web Application Icons"), IconCategory("Hand Icons")]
        HandPeaceOutline = 0xf25b,
        ///<summary>Trademark (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/trademark/" />
        [Description("Trademark"), IconId("trademark"), IconCategory("Web Application Icons")]
        Trademark = 0xf25c,
        ///<summary>Registered Trademark (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/registered/" />
        [Description("Registered Trademark"), IconId("registered"), IconCategory("Web Application Icons")]
        Registered = 0xf25d,
        ///<summary>Creative Commons (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/creative-commons/" />
        [Description("Creative Commons"), IconId("creative-commons"), IconCategory("Web Application Icons")]
        CreativeCommons = 0xf25e,
        ///<summary>GG Currency (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/gg/" />
        [Description("GG Currency"), IconId("gg"), IconCategory("Currency Icons"), IconCategory("Brand Icons")]
        Gg = 0xf260,
        ///<summary>GG Currency Circle (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/gg-circle/" />
        [Description("GG Currency Circle"), IconId("gg-circle"), IconCategory("Currency Icons"), IconCategory("Brand Icons")]
        GgCircle = 0xf261,
        ///<summary>TripAdvisor (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/tripadvisor/" />
        [Description("TripAdvisor"), IconId("tripadvisor"), IconCategory("Brand Icons")]
        Tripadvisor = 0xf262,
        ///<summary>Odnoklassniki (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/odnoklassniki/" />
        [Description("Odnoklassniki"), IconId("odnoklassniki"), IconCategory("Brand Icons")]
        Odnoklassniki = 0xf263,
        ///<summary>Odnoklassniki Square (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/odnoklassniki-square/" />
        [Description("Odnoklassniki Square"), IconId("odnoklassniki-square"), IconCategory("Brand Icons")]
        OdnoklassnikiSquare = 0xf264,
        ///<summary>Get Pocket (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/get-pocket/" />
        [Description("Get Pocket"), IconId("get-pocket"), IconCategory("Brand Icons")]
        GetPocket = 0xf265,
        ///<summary>Wikipedia W (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/wikipedia-w/" />
        [Description("Wikipedia W"), IconId("wikipedia-w"), IconCategory("Brand Icons")]
        WikipediaW = 0xf266,
        ///<summary>Safari (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/safari/" />
        [Description("Safari"), IconId("safari"), IconCategory("Brand Icons")]
        Safari = 0xf267,
        ///<summary>Chrome (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/chrome/" />
        [Description("Chrome"), IconId("chrome"), IconCategory("Brand Icons")]
        Chrome = 0xf268,
        ///<summary>Firefox (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/firefox/" />
        [Description("Firefox"), IconId("firefox"), IconCategory("Brand Icons")]
        Firefox = 0xf269,
        ///<summary>Opera (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/opera/" />
        [Description("Opera"), IconId("opera"), IconCategory("Brand Icons")]
        Opera = 0xf26a,
        ///<summary>Internet-explorer (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/internet-explorer/" />
        [Description("Internet-explorer"), IconId("internet-explorer"), IconCategory("Brand Icons")]
        InternetExplorer = 0xf26b,
        ///<summary>Television (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/television/" />
        [Description("Television"), IconId("television"), IconCategory("Web Application Icons")]
        Television = 0xf26c,
        ///<summary>Alias of: Television</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Television" />
        [IconAlias]
        Tv = Television,
        ///<summary>Contao (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/contao/" />
        [Description("Contao"), IconId("contao"), IconCategory("Brand Icons")]
        Contao = 0xf26d,
        ///<summary>500px (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/500px/" />
        [Description("500px"), IconId("500px"), IconCategory("Brand Icons")]
        _500Px = 0xf26e,
        ///<summary>Amazon (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/amazon/" />
        [Description("Amazon"), IconId("amazon"), IconCategory("Brand Icons")]
        Amazon = 0xf270,
        ///<summary>Calendar Plus Outlined (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/calendar-plus-o/" />
        [Description("Calendar Plus Outlined"), IconId("calendar-plus-o"), IconCategory("Web Application Icons")]
        CalendarPlusOutline = 0xf271,
        ///<summary>Calendar Minus Outlined (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/calendar-minus-o/" />
        [Description("Calendar Minus Outlined"), IconId("calendar-minus-o"), IconCategory("Web Application Icons")]
        CalendarMinusOutline = 0xf272,
        ///<summary>Calendar Times Outlined (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/calendar-times-o/" />
        [Description("Calendar Times Outlined"), IconId("calendar-times-o"), IconCategory("Web Application Icons")]
        CalendarTimesOutline = 0xf273,
        ///<summary>Calendar Check Outlined (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/calendar-check-o/" />
        [Description("Calendar Check Outlined"), IconId("calendar-check-o"), IconCategory("Web Application Icons")]
        CalendarCheckOutline = 0xf274,
        ///<summary>Industry (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/industry/" />
        [Description("Industry"), IconId("industry"), IconCategory("Web Application Icons")]
        Industry = 0xf275,
        ///<summary>Map Pin (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/map-pin/" />
        [Description("Map Pin"), IconId("map-pin"), IconCategory("Web Application Icons")]
        MapPin = 0xf276,
        ///<summary>Map Signs (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/map-signs/" />
        [Description("Map Signs"), IconId("map-signs"), IconCategory("Web Application Icons")]
        MapSigns = 0xf277,
        ///<summary>Map Outlined (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/map-o/" />
        [Description("Map Outlined"), IconId("map-o"), IconCategory("Web Application Icons")]
        MapOutline = 0xf278,
        ///<summary>Map (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/map/" />
        [Description("Map"), IconId("map"), IconCategory("Web Application Icons")]
        Map = 0xf279,
        ///<summary>Commenting (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/commenting/" />
        [Description("Commenting"), IconId("commenting"), IconCategory("Web Application Icons")]
        Commenting = 0xf27a,
        ///<summary>Commenting Outlined (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/commenting-o/" />
        [Description("Commenting Outlined"), IconId("commenting-o"), IconCategory("Web Application Icons")]
        CommentingOutline = 0xf27b,
        ///<summary>Houzz (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/houzz/" />
        [Description("Houzz"), IconId("houzz"), IconCategory("Brand Icons")]
        Houzz = 0xf27c,
        ///<summary>Vimeo (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/vimeo/" />
        [Description("Vimeo"), IconId("vimeo"), IconCategory("Brand Icons")]
        Vimeo = 0xf27d,
        ///<summary>Font Awesome Black Tie (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/black-tie/" />
        [Description("Font Awesome Black Tie"), IconId("black-tie"), IconCategory("Brand Icons")]
        BlackTie = 0xf27e,
        ///<summary>Fonticons (created: 4.4)</summary>
        ///<see href="http://fontawesome.io/icon/fonticons/" />
        [Description("Fonticons"), IconId("fonticons"), IconCategory("Brand Icons")]
        Fonticons = 0xf280,
        ///<summary>reddit Alien (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/reddit-alien/" />
        [Description("reddit Alien"), IconId("reddit-alien"), IconCategory("Brand Icons")]
        RedditAlien = 0xf281,
        ///<summary>Edge Browser (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/edge/" />
        [Description("Edge Browser"), IconId("edge"), IconCategory("Brand Icons")]
        Edge = 0xf282,
        ///<summary>Credit Card (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/credit-card-alt/" />
        [Description("Credit Card"), IconId("credit-card-alt"), IconCategory("Payment Icons"), IconCategory("Web Application Icons")]
        CreditCardAlt = 0xf283,
        ///<summary>Codie Pie (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/codiepie/" />
        [Description("Codie Pie"), IconId("codiepie"), IconCategory("Brand Icons")]
        Codiepie = 0xf284,
        ///<summary>MODX (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/modx/" />
        [Description("MODX"), IconId("modx"), IconCategory("Brand Icons")]
        Modx = 0xf285,
        ///<summary>Fort Awesome (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/fort-awesome/" />
        [Description("Fort Awesome"), IconId("fort-awesome"), IconCategory("Brand Icons")]
        FortAwesome = 0xf286,
        ///<summary>USB (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/usb/" />
        [Description("USB"), IconId("usb"), IconCategory("Brand Icons")]
        Usb = 0xf287,
        ///<summary>Product Hunt (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/product-hunt/" />
        [Description("Product Hunt"), IconId("product-hunt"), IconCategory("Brand Icons")]
        ProductHunt = 0xf288,
        ///<summary>Mixcloud (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/mixcloud/" />
        [Description("Mixcloud"), IconId("mixcloud"), IconCategory("Brand Icons")]
        Mixcloud = 0xf289,
        ///<summary>Scribd (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/scribd/" />
        [Description("Scribd"), IconId("scribd"), IconCategory("Brand Icons")]
        Scribd = 0xf28a,
        ///<summary>Pause Circle (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/pause-circle/" />
        [Description("Pause Circle"), IconId("pause-circle"), IconCategory("Video Player Icons")]
        PauseCircle = 0xf28b,
        ///<summary>Pause Circle Outlined (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/pause-circle-o/" />
        [Description("Pause Circle Outlined"), IconId("pause-circle-o"), IconCategory("Video Player Icons")]
        PauseCircleOutline = 0xf28c,
        ///<summary>Stop Circle (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/stop-circle/" />
        [Description("Stop Circle"), IconId("stop-circle"), IconCategory("Video Player Icons")]
        StopCircle = 0xf28d,
        ///<summary>Stop Circle Outlined (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/stop-circle-o/" />
        [Description("Stop Circle Outlined"), IconId("stop-circle-o"), IconCategory("Video Player Icons")]
        StopCircleOutline = 0xf28e,
        ///<summary>Shopping Bag (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/shopping-bag/" />
        [Description("Shopping Bag"), IconId("shopping-bag"), IconCategory("Web Application Icons")]
        ShoppingBag = 0xf290,
        ///<summary>Shopping Basket (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/shopping-basket/" />
        [Description("Shopping Basket"), IconId("shopping-basket"), IconCategory("Web Application Icons")]
        ShoppingBasket = 0xf291,
        ///<summary>Hashtag (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/hashtag/" />
        [Description("Hashtag"), IconId("hashtag"), IconCategory("Web Application Icons")]
        Hashtag = 0xf292,
        ///<summary>Bluetooth (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/bluetooth/" />
        [Description("Bluetooth"), IconId("bluetooth"), IconCategory("Web Application Icons"), IconCategory("Brand Icons")]
        Bluetooth = 0xf293,
        ///<summary>Bluetooth (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/bluetooth-b/" />
        [Description("Bluetooth"), IconId("bluetooth-b"), IconCategory("Web Application Icons"), IconCategory("Brand Icons")]
        BluetoothB = 0xf294,
        ///<summary>Percent (created: 4.5)</summary>
        ///<see href="http://fontawesome.io/icon/percent/" />
        [Description("Percent"), IconId("percent"), IconCategory("Web Application Icons")]
        Percent = 0xf295,
        ///<summary>GitLab (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/gitlab/" />
        [Description("GitLab"), IconId("gitlab"), IconCategory("Brand Icons")]
        Gitlab = 0xf296,
        ///<summary>WPBeginner (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/wpbeginner/" />
        [Description("WPBeginner"), IconId("wpbeginner"), IconCategory("Brand Icons")]
        Wpbeginner = 0xf297,
        ///<summary>WPForms (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/wpforms/" />
        [Description("WPForms"), IconId("wpforms"), IconCategory("Brand Icons")]
        Wpforms = 0xf298,
        ///<summary>Envira Gallery (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/envira/" />
        [Description("Envira Gallery"), IconId("envira"), IconCategory("Brand Icons")]
        Envira = 0xf299,
        ///<summary>Universal Access (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/universal-access/" />
        [Description("Universal Access"), IconId("universal-access"), IconCategory("Web Application Icons"), IconCategory("Accessibility Icons")]
        UniversalAccess = 0xf29a,
        ///<summary>Wheelchair Alt (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/wheelchair-alt/" />
        [Description("Wheelchair Alt"), IconId("wheelchair-alt"), IconCategory("Web Application Icons"), IconCategory("Medical Icons"), IconCategory("Transportation Icons"), IconCategory("Accessibility Icons")]
        WheelchairAlt = 0xf29b,
        ///<summary>Question Circle Outlined (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/question-circle-o/" />
        [Description("Question Circle Outlined"), IconId("question-circle-o"), IconCategory("Web Application Icons"), IconCategory("Accessibility Icons")]
        QuestionCircleOutline = 0xf29c,
        ///<summary>Blind (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/blind/" />
        [Description("Blind"), IconId("blind"), IconCategory("Web Application Icons"), IconCategory("Accessibility Icons")]
        Blind = 0xf29d,
        ///<summary>Audio Description (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/audio-description/" />
        [Description("Audio Description"), IconId("audio-description"), IconCategory("Web Application Icons"), IconCategory("Accessibility Icons")]
        AudioDescription = 0xf29e,
        ///<summary>Volume Control Phone (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/volume-control-phone/" />
        [Description("Volume Control Phone"), IconId("volume-control-phone"), IconCategory("Web Application Icons"), IconCategory("Accessibility Icons")]
        VolumeControlPhone = 0xf2a0,
        ///<summary>Braille (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/braille/" />
        [Description("Braille"), IconId("braille"), IconCategory("Web Application Icons"), IconCategory("Accessibility Icons")]
        Braille = 0xf2a1,
        ///<summary>Assistive Listening Systems (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/assistive-listening-systems/" />
        [Description("Assistive Listening Systems"), IconId("assistive-listening-systems"), IconCategory("Web Application Icons"), IconCategory("Accessibility Icons")]
        AssistiveListeningSystems = 0xf2a2,
        ///<summary>American Sign Language Interpreting (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/american-sign-language-interpreting/" />
        [Description("American Sign Language Interpreting"), IconId("american-sign-language-interpreting"), IconCategory("Web Application Icons"), IconCategory("Accessibility Icons")]
        AmericanSignLanguageInterpreting = 0xf2a3,
        ///<summary>Alias of: AmericanSignLanguageInterpreting</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.AmericanSignLanguageInterpreting" />
        [IconAlias]
        AslInterpreting = AmericanSignLanguageInterpreting,
        ///<summary>Deaf (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/deaf/" />
        [Description("Deaf"), IconId("deaf"), IconCategory("Web Application Icons"), IconCategory("Accessibility Icons")]
        Deaf = 0xf2a4,
        ///<summary>Alias of: Deaf</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Deaf" />
        [IconAlias]
        Deafness = Deaf,
        ///<summary>Alias of: Deaf</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Deaf" />
        [IconAlias]
        HardOfHearing = Deaf,
        ///<summary>Glide (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/glide/" />
        [Description("Glide"), IconId("glide"), IconCategory("Brand Icons")]
        Glide = 0xf2a5,
        ///<summary>Glide G (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/glide-g/" />
        [Description("Glide G"), IconId("glide-g"), IconCategory("Brand Icons")]
        GlideG = 0xf2a6,
        ///<summary>Sign Language (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/sign-language/" />
        [Description("Sign Language"), IconId("sign-language"), IconCategory("Web Application Icons"), IconCategory("Accessibility Icons")]
        SignLanguage = 0xf2a7,
        ///<summary>Alias of: SignLanguage</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.SignLanguage" />
        [IconAlias]
        Signing = SignLanguage,
        ///<summary>Low Vision (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/low-vision/" />
        [Description("Low Vision"), IconId("low-vision"), IconCategory("Web Application Icons"), IconCategory("Accessibility Icons")]
        LowVision = 0xf2a8,
        ///<summary>Viadeo (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/viadeo/" />
        [Description("Viadeo"), IconId("viadeo"), IconCategory("Brand Icons")]
        Viadeo = 0xf2a9,
        ///<summary>Viadeo Square (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/viadeo-square/" />
        [Description("Viadeo Square"), IconId("viadeo-square"), IconCategory("Brand Icons")]
        ViadeoSquare = 0xf2aa,
        ///<summary>Snapchat (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/snapchat/" />
        [Description("Snapchat"), IconId("snapchat"), IconCategory("Brand Icons")]
        Snapchat = 0xf2ab,
        ///<summary>Snapchat Ghost (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/snapchat-ghost/" />
        [Description("Snapchat Ghost"), IconId("snapchat-ghost"), IconCategory("Brand Icons")]
        SnapchatGhost = 0xf2ac,
        ///<summary>Snapchat Square (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/snapchat-square/" />
        [Description("Snapchat Square"), IconId("snapchat-square"), IconCategory("Brand Icons")]
        SnapchatSquare = 0xf2ad,
        ///<summary>Pied Piper Logo (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/pied-piper/" />
        [Description("Pied Piper Logo"), IconId("pied-piper"), IconCategory("Brand Icons")]
        PiedPiper = 0xf2ae,
        ///<summary>First Order (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/first-order/" />
        [Description("First Order"), IconId("first-order"), IconCategory("Brand Icons")]
        FirstOrder = 0xf2b0,
        ///<summary>Yoast (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/yoast/" />
        [Description("Yoast"), IconId("yoast"), IconCategory("Brand Icons")]
        Yoast = 0xf2b1,
        ///<summary>ThemeIsle (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/themeisle/" />
        [Description("ThemeIsle"), IconId("themeisle"), IconCategory("Brand Icons")]
        Themeisle = 0xf2b2,
        ///<summary>Google Plus Official (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/google-plus-official/" />
        [Description("Google Plus Official"), IconId("google-plus-official"), IconCategory("Brand Icons")]
        GooglePlusOfficial = 0xf2b3,
        ///<summary>Alias of: GooglePlusOfficial</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.GooglePlusOfficial" />
        [IconAlias]
        GooglePlusCircle = GooglePlusOfficial,
        ///<summary>Font Awesome (created: 4.6)</summary>
        ///<see href="http://fontawesome.io/icon/font-awesome/" />
        [Description("Font Awesome"), IconId("font-awesome"), IconCategory("Brand Icons")]
        FontAwesome = 0xf2b4,
        ///<summary>Alias of: FontAwesome</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.FontAwesome" />
        [IconAlias]
        Fa = FontAwesome,
        ///<summary>Handshake Outlined (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/handshake-o/" />
        [Description("Handshake Outlined"), IconId("handshake-o"), IconCategory("Web Application Icons")]
        HandshakeOutline = 0xf2b5,
        ///<summary>Envelope Open (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/envelope-open/" />
        [Description("Envelope Open"), IconId("envelope-open"), IconCategory("Web Application Icons")]
        EnvelopeOpen = 0xf2b6,
        ///<summary>Envelope Open Outlined (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/envelope-open-o/" />
        [Description("Envelope Open Outlined"), IconId("envelope-open-o"), IconCategory("Web Application Icons")]
        EnvelopeOutlinepenOutline = 0xf2b7,
        ///<summary>Linode (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/linode/" />
        [Description("Linode"), IconId("linode"), IconCategory("Brand Icons")]
        Linode = 0xf2b8,
        ///<summary>Address Book (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/address-book/" />
        [Description("Address Book"), IconId("address-book"), IconCategory("Web Application Icons")]
        AddressBook = 0xf2b9,
        ///<summary>Address Book Outlined (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/address-book-o/" />
        [Description("Address Book Outlined"), IconId("address-book-o"), IconCategory("Web Application Icons")]
        AddressBookOutline = 0xf2ba,
        ///<summary>Address Card (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/address-card/" />
        [Description("Address Card"), IconId("address-card"), IconCategory("Web Application Icons")]
        AddressCard = 0xf2bb,
        ///<summary>Alias of: AddressCard</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.AddressCard" />
        [IconAlias]
        Vcard = AddressCard,
        ///<summary>Address Card Outlined (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/address-card-o/" />
        [Description("Address Card Outlined"), IconId("address-card-o"), IconCategory("Web Application Icons")]
        AddressCardOutline = 0xf2bc,
        ///<summary>Alias of: AddressCardOutline</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.AddressCardOutline" />
        [IconAlias]
        VcardOutline = AddressCardOutline,
        ///<summary>User Circle (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/user-circle/" />
        [Description("User Circle"), IconId("user-circle"), IconCategory("Web Application Icons")]
        UserCircle = 0xf2bd,
        ///<summary>User Circle Outlined (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/user-circle-o/" />
        [Description("User Circle Outlined"), IconId("user-circle-o"), IconCategory("Web Application Icons")]
        UserCircleOutline = 0xf2be,
        ///<summary>User Outlined (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/user-o/" />
        [Description("User Outlined"), IconId("user-o"), IconCategory("Web Application Icons")]
        UserOutline = 0xf2c0,
        ///<summary>Identification Badge (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/id-badge/" />
        [Description("Identification Badge"), IconId("id-badge"), IconCategory("Web Application Icons")]
        IdBadge = 0xf2c1,
        ///<summary>Identification Card (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/id-card/" />
        [Description("Identification Card"), IconId("id-card"), IconCategory("Web Application Icons")]
        IdCard = 0xf2c2,
        ///<summary>Alias of: IdCard</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.IdCard" />
        [IconAlias]
        DriversLicense = IdCard,
        ///<summary>Identification Card Outlined (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/id-card-o/" />
        [Description("Identification Card Outlined"), IconId("id-card-o"), IconCategory("Web Application Icons")]
        IdCardOutline = 0xf2c3,
        ///<summary>Alias of: IdCardOutline</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.IdCardOutline" />
        [IconAlias]
        DriversLicenseOutline = IdCardOutline,
        ///<summary>Quora (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/quora/" />
        [Description("Quora"), IconId("quora"), IconCategory("Brand Icons")]
        Quora = 0xf2c4,
        ///<summary>Free Code Camp (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/free-code-camp/" />
        [Description("Free Code Camp"), IconId("free-code-camp"), IconCategory("Brand Icons")]
        FreeCodeCamp = 0xf2c5,
        ///<summary>Telegram (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/telegram/" />
        [Description("Telegram"), IconId("telegram"), IconCategory("Brand Icons")]
        Telegram = 0xf2c6,
        ///<summary>Thermometer Full (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/thermometer-full/" />
        [Description("Thermometer Full"), IconId("thermometer-full"), IconCategory("Web Application Icons")]
        ThermometerFull = 0xf2c7,
        ///<summary>Alias of: ThermometerFull</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.ThermometerFull" />
        [IconAlias]
        Thermometer4 = ThermometerFull,
        ///<summary>Alias of: ThermometerFull</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.ThermometerFull" />
        [IconAlias]
        Thermometer = ThermometerFull,
        ///<summary>Thermometer 3/4 Full (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/thermometer-three-quarters/" />
        [Description("Thermometer 3/4 Full"), IconId("thermometer-three-quarters"), IconCategory("Web Application Icons")]
        ThermometerThreeQuarters = 0xf2c8,
        ///<summary>Alias of: ThermometerThreeQuarters</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.ThermometerThreeQuarters" />
        [IconAlias]
        Thermometer3 = ThermometerThreeQuarters,
        ///<summary>Thermometer 1/2 Full (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/thermometer-half/" />
        [Description("Thermometer 1/2 Full"), IconId("thermometer-half"), IconCategory("Web Application Icons")]
        ThermometerHalf = 0xf2c9,
        ///<summary>Alias of: ThermometerHalf</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.ThermometerHalf" />
        [IconAlias]
        Thermometer2 = ThermometerHalf,
        ///<summary>Thermometer 1/4 Full (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/thermometer-quarter/" />
        [Description("Thermometer 1/4 Full"), IconId("thermometer-quarter"), IconCategory("Web Application Icons")]
        ThermometerQuarter = 0xf2ca,
        ///<summary>Alias of: ThermometerQuarter</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.ThermometerQuarter" />
        [IconAlias]
        Thermometer1 = ThermometerQuarter,
        ///<summary>Thermometer Empty (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/thermometer-empty/" />
        [Description("Thermometer Empty"), IconId("thermometer-empty"), IconCategory("Web Application Icons")]
        ThermometerEmpty = 0xf2cb,
        ///<summary>Alias of: ThermometerEmpty</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.ThermometerEmpty" />
        [IconAlias]
        Thermometer0 = ThermometerEmpty,
        ///<summary>Shower (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/shower/" />
        [Description("Shower"), IconId("shower"), IconCategory("Web Application Icons")]
        Shower = 0xf2cc,
        ///<summary>Bath (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/bath/" />
        [Description("Bath"), IconId("bath"), IconCategory("Web Application Icons")]
        Bath = 0xf2cd,
        ///<summary>Alias of: Bath</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Bath" />
        [IconAlias]
        Bathtub = Bath,
        ///<summary>Alias of: Bath</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.Bath" />
        [IconAlias]
        S15 = Bath,
        ///<summary>Podcast (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/podcast/" />
        [Description("Podcast"), IconId("podcast"), IconCategory("Web Application Icons")]
        Podcast = 0xf2ce,
        ///<summary>Window Maximize (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/window-maximize/" />
        [Description("Window Maximize"), IconId("window-maximize"), IconCategory("Web Application Icons")]
        WindowMaximize = 0xf2d0,
        ///<summary>Window Minimize (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/window-minimize/" />
        [Description("Window Minimize"), IconId("window-minimize"), IconCategory("Web Application Icons")]
        WindowMinimize = 0xf2d1,
        ///<summary>Window Restore (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/window-restore/" />
        [Description("Window Restore"), IconId("window-restore"), IconCategory("Web Application Icons")]
        WindowRestore = 0xf2d2,
        ///<summary>Window Close (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/window-close/" />
        [Description("Window Close"), IconId("window-close"), IconCategory("Web Application Icons")]
        WindowClose = 0xf2d3,
        ///<summary>Alias of: WindowClose</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.WindowClose" />
        [IconAlias]
        TimesRectangle = WindowClose,
        ///<summary>Window Close Outline (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/window-close-o/" />
        [Description("Window Close Outline"), IconId("window-close-o"), IconCategory("Web Application Icons")]
        WindowCloseOutline = 0xf2d4,
        ///<summary>Alias of: WindowCloseOutline</summary>
        ///<see cref="F:FontAwesome.WPF.FontAwesomeIcon.WindowCloseOutline" />
        [IconAlias]
        TimesRectangleOutline = WindowCloseOutline,
        ///<summary>Bandcamp (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/bandcamp/" />
        [Description("Bandcamp"), IconId("bandcamp"), IconCategory("Brand Icons")]
        Bandcamp = 0xf2d5,
        ///<summary>Grav (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/grav/" />
        [Description("Grav"), IconId("grav"), IconCategory("Brand Icons")]
        Grav = 0xf2d6,
        ///<summary>Etsy (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/etsy/" />
        [Description("Etsy"), IconId("etsy"), IconCategory("Brand Icons")]
        Etsy = 0xf2d7,
        ///<summary>IMDB (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/imdb/" />
        [Description("IMDB"), IconId("imdb"), IconCategory("Brand Icons")]
        Imdb = 0xf2d8,
        ///<summary>Ravelry (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/ravelry/" />
        [Description("Ravelry"), IconId("ravelry"), IconCategory("Brand Icons")]
        Ravelry = 0xf2d9,
        ///<summary>Eercast (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/eercast/" />
        [Description("Eercast"), IconId("eercast"), IconCategory("Brand Icons")]
        Eercast = 0xf2da,
        ///<summary>Microchip (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/microchip/" />
        [Description("Microchip"), IconId("microchip"), IconCategory("Web Application Icons")]
        Microchip = 0xf2db,
        ///<summary>Snowflake Outlined (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/snowflake-o/" />
        [Description("Snowflake Outlined"), IconId("snowflake-o"), IconCategory("Web Application Icons")]
        SnowflakeOutline = 0xf2dc,
        ///<summary>Superpowers (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/superpowers/" />
        [Description("Superpowers"), IconId("superpowers"), IconCategory("Brand Icons")]
        Superpowers = 0xf2dd,
        ///<summary>WPExplorer (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/wpexplorer/" />
        [Description("WPExplorer"), IconId("wpexplorer"), IconCategory("Brand Icons")]
        Wpexplorer = 0xf2de,
        ///<summary>Meetup (created: 4.7)</summary>
        ///<see href="http://fontawesome.io/icon/meetup/" />
        [Description("Meetup"), IconId("meetup"), IconCategory("Brand Icons")]
        Meetup = 0xf2e0,
    }

}
