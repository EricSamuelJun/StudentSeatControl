using System.Drawing;

namespace TeacherSeatSetter.Objects {
    /// <summary>
    /// 앱 전체 공통 색상 체계
    /// </summary>
    public static class AppColors {
        // ── Primary (네이비 블루 — 브랜드, 네비게이션) ──
        public static readonly Color Primary = Color.FromArgb(55, 71, 133);
        public static readonly Color PrimaryLight = Color.FromArgb(78, 96, 164);
        public static readonly Color PrimaryDark = Color.FromArgb(40, 53, 100);

        // ── Accent (밝은 블루 — 주요 CTA) ──
        public static readonly Color Accent = Color.FromArgb(66, 165, 245);
        public static readonly Color AccentHover = Color.FromArgb(33, 150, 243);

        // ── Semantic (의미별) ──
        public static readonly Color Success = Color.FromArgb(76, 175, 80);
        public static readonly Color Danger = Color.FromArgb(229, 57, 53);
        public static readonly Color Warning = Color.FromArgb(255, 167, 38);
        public static readonly Color Muted = Color.FromArgb(158, 158, 158);

        // ── Surface / Background ──
        public static readonly Color Background = Color.FromArgb(245, 245, 248);
        public static readonly Color Surface = Color.White;
        public static readonly Color SidebarBg = Color.FromArgb(40, 53, 100);
        public static readonly Color Divider = Color.FromArgb(224, 224, 224);

        // ── Text ──
        public static readonly Color TextPrimary = Color.FromArgb(33, 33, 33);
        public static readonly Color TextSecondary = Color.FromArgb(117, 117, 117);
        public static readonly Color TextOnPrimary = Color.White;

        // ── DataGridView 전용 ──
        public static readonly Color GridHeader = Color.FromArgb(55, 71, 133);
        public static readonly Color GridHeaderText = Color.White;
        public static readonly Color GridSelection = Color.FromArgb(66, 165, 245);
        public static readonly Color GridSelectionText = Color.White;
        public static readonly Color GridRowAlt = Color.FromArgb(248, 249, 252);
        public static readonly Color GridCellText = Color.FromArgb(80, 80, 80);

        // ── 교탁 ──
        public static readonly Color TeacherTable = Color.FromArgb(40, 53, 100);
        public static readonly Color TeacherTableText = Color.White;

        // ── Nav 버튼 상태 ──
        public static readonly Color NavDefault = Color.FromArgb(55, 71, 133);
        public static readonly Color NavActive = Color.FromArgb(78, 96, 164);
        public static readonly Color NavText = Color.White;
    }
}
