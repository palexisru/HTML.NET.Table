using System;
using System.Text;

namespace pl2.Data.HTML.Record
{
    public class Read_me
    {
    }
    public class Data
    {
        public const string charset_string = "charset=";
        public const int std_codepage = 1521;
        public int codepage ;             // активная кодовая страница
        public long field_description_len; // длина описания одного поля
        public long field_description_position; // начало описания полей
        public long field_count;          // количество полей
        public long field_count_position; // позиция считывания количества полей
        public long header_size;          // размер заголовка до начала записей (до <table>)
        public long header_size_position; // позиция считывания размера заголовка
        public long reclength;            // размер записи
        public long reclength_position;   // позиция считывания размера записи
        public long reccount;             // количество записей
        public long reccount_position;    // позиция количества записей
        public long current_record_position;
        public Encoding
    }
}

#if false
{
   LINK4  link ;

   /* Database Header Information */
   char     version ;        /* 83H with .dbt, 03H without */
   char     yy ;             /* Last Update */
   char     mm ;
   char     dd ;
   long     num_recs ;
   unsigned short header_len; /* Header Length, Indicates start of data */

   char S4PTR *record ;              /* Data allocated with 'u4alloc' */
   char S4PTR *record_old ;          /* Data allocated with 'u4alloc' */
                                 /* Extra byte added for temporary CTRL_Z */
   unsigned record_width ;
   int      record_changed ;      /* T/F */
   long     rec_num ;             /* Record number; -1 unknown; 0 for append */
   long     rec_num_old ;         /* Record number, -1 none present; 0 for append */

   FILE4    file ;
   char     alias[11] ;

   char     memo_validated ; /* Can we be sure memo id #'s are up to date. */

   CODE4 S4PTR *code_base ;
   short    has_mdx ;        /* Has an MDX file attached to it */

   FIELD4  S4PTR *fields ;        /* An array of field pointers */
   int      n_fields ;       /* The number of data fields in the database */

   F4MEMO   S4PTR *fields_memo ;    /* A list of fields to be flushed */
   int      n_fields_memo ;  /* The number of memo files in the database */

   long     locked_record ;  /* 'locks' data when 'n_locks <= 1' */
   long     S4PTR *locks ;
   int      n_locks ;        /* Number of elements in 'locks' allocated */
   int      num_locked ;     /* Number of records locked */
   int      file_lock ;      /* True if entire file is locked */
   int      append_lock ;    /* True if the file is locked for appending */

   int      file_changed ;   /* True if the file has been changed since */
                                /* the header has been updated. */

   LIST4    indexes ;
   int      bof_flag, eof_flag ;    /* Beginning/End of File flags */

   short    block_size ;
   MEMO4FILE   memo_file ;      /* Memo file handle */
   #ifdef S4VBASIC
      int   debug_int ;      /* used to check structure integrity (set to 0x5281) */
   #endif
} DATA4 ;


char *S4FUNCTION d4alias( DATA4 *data )
{
   #ifdef S4DEBUG
      if ( data == 0 )
         e4severe( e4parm, "d4alias()" ) ;
   #endif
   return data->alias ;
}

void S4FUNCTION d4alias_set( DATA4 *data, char *new_alias )
{
   #ifdef S4DEBUG
      if ( data == 0 || new_alias == 0 )
         e4severe( e4parm, "d4alias_set()" ) ;
   #endif
   c4upper( new_alias ) ;
   u4ncpy( data->alias, new_alias, sizeof( data->alias ) ) ;
}

void S4FUNCTION d4blank( DATA4 *data )
{
   #ifdef S4VBASIC
      if ( c4parm_check( data, 2, "d4blank():" ) )
         return ;
   #endif  /* S4VBASIC */

   #ifdef S4DEBUG
      if ( data == 0 )
         e4severe( e4parm, "d4blank()" ) ;
   #endif

   memset( data->record, ' ', data->record_width ) ;
   data->record_changed = 1 ;
}

int S4FUNCTION d4bof( DATA4 *data )
{
   #ifdef S4DEBUG
      if ( data == 0 )
         e4severe( e4parm, "d4bof()" ) ;
   #endif

   return data->bof_flag ;
}

int S4FUNCTION d4bottom( DATA4 *data )
{
   TAG4 *tag ;
   long rec ;
   int  rc ;

   #ifdef S4DEBUG
      if ( data == 0 )
         e4severe( e4parm, "d4bottom()" ) ;
   #endif

   tag = d4tag_selected( data ) ;
   if ( tag == 0 )
   {
      rec = d4reccount( data ) ;  /* updates the record, returns -1 if code_base->error_code < 0 */
      if ( rec > 0L )
         return d4go( data, rec ) ;
   }
   else
   {
      rc = d4update_record( data, 1 ) ;  /* updates the record, returns -1 if code_base->error_code < 0 */
      if ( rc )
         return rc ;
      t4version_check( tag, 0 ) ;
      rc = t4bottom( tag ) ;
      if ( rc )
         return rc ;
      if ( !t4eof(tag) )
         return d4go( data, t4recno( tag ) ) ;
   }

   data->bof_flag = 1 ;
   return d4go_eof( data ) ;
}

void S4FUNCTION d4delete( DATA4 *data )
{
   #ifdef S4VBASIC
      if ( c4parm_check( data, 2, "d4delete():" ) )
         return ;
   #endif  /* S4VBASIC */

   #ifdef S4DEBUG
      if ( data == 0 )
         e4severe( e4parm, "d4delete()" ) ;
      if ( data->record[0] != ' ' && data->record[0] != '*' )
         e4severe( e4info, "d4delete() - invalid deletion flag detected" ) ;
   #endif

   if ( data->record[0] != '*' )
   {
      data->record[0] = '*' ;
      data->record_changed = 1 ;
   }
}

int S4FUNCTION d4deleted( DATA4 *data )
{
   #ifdef S4DEBUG
      if ( data == 0 )
         e4severe( e4parm, "d4deleted()" ) ;
      if ( data->record[0] != ' ' && data->record[0] != '*' )
         e4severe( e4info, "d4deleted() - invalid deletion flag detected" ) ;
   #endif

   return *data->record != ' ' ;
}

int S4FUNCTION d4eof( DATA4 *data )
{
   #ifdef S4DEBUG
      if ( data == 0 )
         e4severe( e4parm, "d4eof()" ) ;
   #endif

   return data->eof_flag ;
}

int S4FUNCTION d4free_blocks( DATA4 *data )
{
   TAG4 *tag_on ;
   int rc ;

   #ifdef S4DEBUG
      if ( data == 0 )
         e4severe( e4parm, "d4free_blocks()" ) ;
   #endif

   rc = 0 ;
   for( tag_on = 0 ;; )
   {
      tag_on = (TAG4 *)d4tag_next( data, tag_on ) ;
      if ( tag_on == 0 )
         return rc ;
      if ( t4free_all( tag_on ) < 0 )
         rc = -1 ;
   }
}

INDEX4 *S4FUNCTION d4index( DATA4 *data, char *index_name )
{
   char index_lookup[258], current[258] ;
   INDEX4 *index_on ;

   #ifdef S4VBASIC
      if ( c4parm_check( data, 2, "d4index():" ) )
         return 0 ;
   #endif  /* S4VBASIC */

   #ifdef S4DEBUG
      if ( data == 0 || index_name == 0 )
         e4severe( e4parm, "d4index()" ) ;
   #endif

   u4name_piece( index_lookup, sizeof(index_lookup), index_name, 1, 0 ) ;
   c4upper( index_lookup ) ;

   for( index_on = 0 ;; )
   {
      index_on = (INDEX4 *) l4next( &data->indexes, index_on) ;
      if ( index_on == 0 )
         return 0 ;
      #ifdef N4OTHER
         u4name_piece( current, sizeof(current), index_on->alias, 1, 0 ) ;
      #else
         u4name_piece( current, sizeof(current), index_on->file.name, 1, 0 ) ;
      #endif  /* N4OTHER */
      c4upper( current ) ;
      if ( !strcmp( current, index_lookup ) )    /* check out data->alias? */
         return index_on ;
   }
}

int S4FUNCTION d4num_fields( DATA4 *data )
{
   #ifdef S4DEBUG
      if ( data == 0 )
         e4severe( e4parm, "d4num_fields()" ) ;
   #endif

   return data->n_fields ;
}

int S4FUNCTION d4read( DATA4 *data, long rec_num, char *ptr )
{
   unsigned len ;

   #ifdef S4DEBUG
      if ( data == 0 || rec_num <= 0 || ptr == 0 )
         e4severe( e4parm, "d4read()" ) ;
   #endif

   if ( data->code_base->error_code < 0 )
      return -1 ;

   len = file4read( &data->file, d4record_position( data, rec_num ), ptr, data->record_width ) ;
   if ( data->code_base->error_code < 0 )
      return -1 ;

   if ( len != data->record_width )
      return r4entry ;

   return 0 ;
}

int S4FUNCTION d4read_old( DATA4 *data, long rec_num )
{
   int rc ;

   #ifdef S4DEBUG
      if ( data == 0 || rec_num <= 0 )
         e4severe( e4parm, "d4read_old()" ) ;
   #endif

   if ( data->code_base->error_code < 0 )
      return -1 ;

   if ( rec_num <= 0 )
   {
      data->rec_num_old = rec_num ;
      memset( data->record_old, ' ', data->record_width ) ;
   }

   if ( data->rec_num_old == rec_num )
      return 0 ;

   data->rec_num_old = -1 ;
   #ifndef S4OPTIMIZE_OFF
      /* make sure read from disk unless file locked, etc. */
      if ( data->file.do_buffer )
         data->code_base->opt.force_current = 1 ;
   #endif
   rc = d4read( data, rec_num, data->record_old) ;
   #ifndef S4OPTIMIZE_OFF
      if ( data->file.do_buffer )
         data->code_base->opt.force_current = 0 ;
   #endif
   if ( rc < 0 )
      return -1 ;
   if ( rc > 0 )
      memset( data->record_old, ' ', data->record_width ) ;
   data->rec_num_old = rec_num ;

   return 0 ;
}

void S4FUNCTION d4recall( DATA4 *data )
{
   #ifdef S4DEBUG
      if ( data == 0 )
         e4severe( e4parm, "d4recall()" ) ;
      if ( data->record[0] != ' ' && data->record[0] != '*' )
         e4severe( e4info, "d4recall() - invalid deletion flag detected" ) ;
   #endif

   if ( *data->record != ' ' )
   {
      *data->record = ' ' ;
      data->record_changed = 1 ;
   }
}

long S4FUNCTION d4reccount( DATA4 *data )
{
   long count ;
   unsigned len ;

   #ifdef S4DEBUG
      if ( data == 0 )
         e4severe( e4parm, "d4reccount()" ) ;
   #endif

   #ifdef S4VBASIC
      if ( c4parm_check( data, 2, "d4reccount():" ) )
         return -1L ;
   #endif  /* S4VBASIC */

   if ( data->code_base->error_code < 0 )
      return -1 ;

   if ( data->num_recs >= 0L )
      return data->num_recs ;

   #ifdef S4CLIPPER
      count = file4len( &data->file ) ;
      if ( count < 0L )
         return -1L ;
      count = ( count - data->header_len )/ data->record_width ;
   #else
      len = file4read( &data->file, 4L, &count, sizeof( long ) ) ;
      if ( count < 0L || len != 4 )
         return -1L ;
   #endif

   #ifndef S4SINGLE
      if ( d4lock_test_append( data ) )
   #endif  /* S4SINGLE */
      data->num_recs = count ;

   return count ;
}

long S4FUNCTION d4recno( DATA4 *data )
{
   #ifdef S4DEBUG
      if ( data == 0 )
         e4severe( e4parm, "d4recno()" ) ;
   #endif

   return data->rec_num ;
}

char *S4FUNCTION d4record( DATA4 *data )
{
   #ifdef S4DEBUG
      if ( data == 0 )
         e4severe( e4parm, "d4record()" ) ;
   #endif

   return data->record ;
}

long S4FUNCTION d4record_position( DATA4 *data, long rec )
{
   #ifdef S4DEBUG
      if ( data == 0 || rec <= 0 )
         e4severe( e4parm, "d4record_position()" ) ;
   #endif

   return data->header_len + data->record_width * ( rec - 1 ) ;
}

long S4FUNCTION d4record_width( DATA4 *data )
{
   #ifdef S4DEBUG
      if ( data == 0 )
         e4severe( e4parm, "d4record_width()" ) ;
   #endif

   return (long)data->record_width ;
}

int S4FUNCTION d4reindex( DATA4 *data )
{
   INDEX4 *index_on ;
   int rc ;
   #ifndef S4OPTIMIZE_OFF
      int has_opt ;
   #endif

   #ifdef S4VBASIC
      if ( c4parm_check( data, 2, "d4reindex():" ) )
         return -1 ;
   #endif  /* S4VBASIC */

   #ifdef S4DEBUG
      if ( data == 0 )
         e4severe( e4parm, "d4reindex()" ) ;
   #endif

   #ifdef S4SINGLE
      if ( data->code_base->error_code < 0 )
         return -1 ;
      rc = 0 ;
   #else
      rc = d4lock_all( data ) ;  /* updates the record, returns -1 if code_base->error_code < 0 */
      if ( rc )
         return rc ;
   #endif  /* S4SINGLE */

   #ifndef S4OPTIMIZE_OFF
      has_opt = data->code_base->has_opt && data->code_base->opt.num_buffers ;
//      has_opt = data->code_base->has_opt ;
      if ( has_opt )
         d4opt_suspend( data->code_base ) ;
   #endif  /* not S4OPTIMIZE_OFF */

   for ( index_on = 0 ;; )
   {
      index_on = (INDEX4 *)l4next( &data->indexes, index_on ) ;
      if ( index_on == 0 )
         break ;
      if ( i4reindex( index_on ) < 0 )
      {
         rc = -1 ;
         break ;
      }
   }

   #ifndef S4OPTIMIZE_OFF
      if ( has_opt )
         d4opt_start( data->code_base ) ;
   #endif  /* not S4OPTIMIZE_OFF */
   return rc ;
}

int S4FUNCTION d4top( DATA4 *data )
{
   TAG4 *tag ;
   int rc, save_flag ;
   CODE4 *c4 ;

   #ifdef S4DEBUG
      if ( data == 0 )
         e4severe( e4parm, "d4top()" ) ;
   #endif

   c4 = data->code_base ;
   if ( c4->error_code < 0 )
      return -1 ;

   tag = d4tag_selected( data ) ;

   if ( tag == 0 )
   {
      save_flag = c4->go_error ;
      c4->go_error = 0 ;
      rc = d4go( data, 1L ) ;
      c4->go_error = save_flag ;
      if ( rc <= 0 )
         return rc ;

      if ( d4reccount( data ) != 0L )
         return d4go( data ,1L ) ;
   }
   else
   {
      rc = d4update_record( data, 1 ) ;
      if ( rc )
         return rc ;
      t4version_check( tag, 0 ) ;
      rc = t4top( tag ) ;
      if ( rc )
         return rc ;
      if ( !t4eof( tag ) )
         return d4go( data , t4recno( tag ) ) ;
   }

   data->bof_flag = 1 ;
   return d4go_eof( data ) ;
}

int S4FUNCTION d4update_header( DATA4 *data, int do_time_stamp, int do_count )
{
   long pos ;
   unsigned len ;
   #ifdef S4BYTE_SWAP
      DATA4_HEADER_FULL swap;
   #endif  /* S4BYTE_SWAP */

   #ifdef S4DEBUG
      if ( data == 0 )
         e4severe( e4parm, "d4update_header()" ) ;
   #endif

   pos = 0L ;
   len = 4 + ( sizeof( long ) ) + ( sizeof( short ) ) ;
   if ( do_time_stamp )
      u4yymmdd( &data->yy ) ;
   else
   {
      pos += 4 ;
      len -= 4 ;
   }

   #ifdef S4DEBUG
      if  ( do_count && ( data->num_recs < 0 || d4lock_test_append( data ) == 0 ) )
         e4severe( e4info, "Number records unknown at update time" ) ;
   #endif

   if ( !do_count )
      len -= (sizeof( data->num_recs ) + sizeof( data->header_len ) ) ;

   #ifdef S4BYTE_SWAP
      memcpy( (void *)&swap, (void *)&data->version, len ) ;
      swap.num_recs = x4reverse_long( swap.num_recs ) ;
      swap.header_len = x4reverse_short( swap.header_len ) ;
      if ( file4write( &data->file, pos, &swap + pos, len ) < 0 )
         return -1 ;
   #else
      if ( file4write( &data->file, pos, (char *)&data->version + pos, len ) < 0 )
         return -1 ;
   #endif  /* S4BYTE_SWAP */

   data->file_changed = 0 ;
   return 0 ;
}
#endif