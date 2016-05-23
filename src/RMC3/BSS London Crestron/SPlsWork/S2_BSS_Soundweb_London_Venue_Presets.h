#ifndef __S2_BSS_SOUNDWEB_LONDON_VENUE_PRESETS_H__
#define __S2_BSS_SOUNDWEB_LONDON_VENUE_PRESETS_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/

#define __S2_BSS_Soundweb_London_Venue_Presets_RECALLPRESET$_DIG_INPUT 0
#define __S2_BSS_Soundweb_London_Venue_Presets_RECALLPRESET$_ARRAY_LENGTH 100

/*
* ANALOG_INPUT
*/




/*
* DIGITAL_OUTPUT
*/


/*
* ANALOG_OUTPUT
*/

#define __S2_BSS_Soundweb_London_Venue_Presets_TX$_STRING_OUTPUT 0


/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* STRING_PARAMETER
*/


/*
* INTEGER
*/


/*
* LONG_INTEGER
*/


/*
* SIGNED_INTEGER
*/


/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/
#define __S2_BSS_Soundweb_London_Venue_Presets_RETURNSTRING_STRING_MAX_LEN 4
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Venue_Presets, __RETURNSTRING, __S2_BSS_Soundweb_London_Venue_Presets_RETURNSTRING_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_Venue_Presets_COMMAND_STRING_MAX_LEN 80
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Venue_Presets, __COMMAND, __S2_BSS_Soundweb_London_Venue_Presets_COMMAND_STRING_MAX_LEN );
#define __S2_BSS_Soundweb_London_Venue_Presets_SENDSTRING_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_BSS_Soundweb_London_Venue_Presets, __SENDSTRING, __S2_BSS_Soundweb_London_Venue_Presets_SENDSTRING_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_BSS_Soundweb_London_Venue_Presets )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __RECALLPRESET$ );
};

START_NVRAM_VAR_STRUCT( S2_BSS_Soundweb_London_Venue_Presets )
{
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Venue_Presets, __RETURNSTRING );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Venue_Presets, __COMMAND );
   DECLARE_STRING_STRUCT( S2_BSS_Soundweb_London_Venue_Presets, __SENDSTRING );
   unsigned short __X;
   unsigned short __I;
   unsigned short __CHECKSUM;
};



#endif //__S2_BSS_SOUNDWEB_LONDON_VENUE_PRESETS_H__

