// Native structure offsets for glibc, on x86 and x86_64.
// Generated using GlibcOffsetGen. Do not modify.

using System;
using System.Runtime.InteropServices;
namespace GlibcInterop
{
    [StructLayout(LayoutKind.Explicit, Size = 4152)]
    unsafe partial struct rtld_global_2_33_64
    {
        [FieldOffset(0)]
        fixed byte _dl_ns[2432];
        [FieldOffset(2432)]
        fixed byte _dl_nns[8];
        [FieldOffset(2440)]
        fixed byte _dl_load_lock[40];
        [FieldOffset(2480)]
        fixed byte _dl_load_write_lock[40];
        [FieldOffset(2520)]
        fixed byte _dl_load_adds[8];
        [FieldOffset(2544)]
        fixed byte _dl_num_relocations[8];
        [FieldOffset(2552)]
        fixed byte _dl_num_cache_relocations[8];
        [FieldOffset(2568)]
        fixed byte _dl_rtld_map[1160];
        [FieldOffset(3728)]
        fixed byte _dl_rtld_auditstate[256];
        [FieldOffset(4000)]
        fixed byte _dl_x86_feature_1[4];
        [FieldOffset(4004)]
        fixed byte _dl_x86_feature_control[4];
        [FieldOffset(4016)]
        fixed byte _dl_stack_flags[4];
        [FieldOffset(4020)]
        fixed byte _dl_tls_dtv_gaps[1];
        [FieldOffset(4024)]
        fixed byte _dl_tls_max_dtv_idx[8];
        [FieldOffset(4040)]
        fixed byte _dl_tls_static_nelem[8];
        [FieldOffset(4048)]
        fixed byte _dl_tls_static_size[8];
        [FieldOffset(4056)]
        fixed byte _dl_tls_static_used[8];
        [FieldOffset(4064)]
        fixed byte _dl_tls_static_align[8];
        [FieldOffset(4072)]
        fixed byte _dl_tls_static_optional[8];
        [FieldOffset(4088)]
        fixed byte _dl_tls_generation[8];
        [FieldOffset(4112)]
        fixed byte _dl_stack_used[16];
        [FieldOffset(4128)]
        fixed byte _dl_stack_user[16];
        [FieldOffset(4144)]
        fixed byte _dl_stack_cache_lock[4];
    }

    [StructLayout(LayoutKind.Explicit, Size = 1160)]
    unsafe partial struct link_map_2_33_64
    {
        [FieldOffset(0)]
        fixed byte l_addr[8];
        [FieldOffset(48)]
        fixed byte l_ns[8];
        [FieldOffset(688)]
        fixed byte l_entry[8];
        [FieldOffset(696)]
        fixed byte l_phnum[2];
        [FieldOffset(698)]
        fixed byte l_ldnum[2];
        [FieldOffset(704)]
        fixed byte l_searchlist[16];
        [FieldOffset(720)]
        fixed byte l_symbolic_searchlist[16];
        [FieldOffset(752)]
        fixed byte l_nversions[4];
        [FieldOffset(756)]
        fixed byte l_nbuckets[4];
        [FieldOffset(760)]
        fixed byte l_gnu_bitmask_idxbits[4];
        [FieldOffset(764)]
        fixed byte l_gnu_shift[4];
        [FieldOffset(792)]
        fixed byte l_direct_opencount[4];
        [FieldOffset(799)]
        fixed byte l_nodelete_active[1];
        [FieldOffset(800)]
        fixed byte l_nodelete_pending[1];
        [FieldOffset(804)]
        fixed byte l_x86_feature_1_and[4];
        [FieldOffset(808)]
        fixed byte l_x86_isa_1_needed[4];
        [FieldOffset(816)]
        fixed byte l_rpath_dirs[16];
        [FieldOffset(856)]
        fixed byte l_map_start[8];
        [FieldOffset(864)]
        fixed byte l_map_end[8];
        [FieldOffset(872)]
        fixed byte l_text_end[8];
        [FieldOffset(912)]
        fixed byte l_scope_max[8];
        [FieldOffset(944)]
        fixed byte l_file_id[16];
        [FieldOffset(960)]
        fixed byte l_runpath_dirs[16];
        [FieldOffset(992)]
        fixed byte l_reldepsmax[4];
        [FieldOffset(996)]
        fixed byte l_used[4];
        [FieldOffset(1000)]
        fixed byte l_feature_1[4];
        [FieldOffset(1004)]
        fixed byte l_flags_1[4];
        [FieldOffset(1008)]
        fixed byte l_flags[4];
        [FieldOffset(1012)]
        fixed byte l_idx[4];
        [FieldOffset(1016)]
        fixed byte l_mach[24];
        [FieldOffset(1040)]
        fixed byte l_lookup_cache[32];
        [FieldOffset(1080)]
        fixed byte l_tls_initimage_size[8];
        [FieldOffset(1088)]
        fixed byte l_tls_blocksize[8];
        [FieldOffset(1096)]
        fixed byte l_tls_align[8];
        [FieldOffset(1104)]
        fixed byte l_tls_firstbyte_offset[8];
        [FieldOffset(1112)]
        fixed byte l_tls_offset[8];
        [FieldOffset(1120)]
        fixed byte l_tls_modid[8];
        [FieldOffset(1128)]
        fixed byte l_tls_dtor_count[8];
        [FieldOffset(1136)]
        fixed byte l_relro_addr[8];
        [FieldOffset(1144)]
        fixed byte l_relro_size[8];
        [FieldOffset(1152)]
        fixed byte l_serial[8];
    }

}
