¶
fd:\BridgeLabz-Training\collections-csharp-practice\scenario-based\event-tracker\AuditTrailAttribute.cs
	namespace 	
EventTrackerApp
 
; 
[ 
AttributeUsage 
( 
AttributeTargets  
.  !
Method! '
)' (
]( )
public 
class 
AuditTrailAttribute  
:! "
	Attribute# ,
{ 
public 

string 
	EventName 
{ 
get !
;! "
}# $
public		 

string		 
Description		 
{		 
get		  #
;		# $
}		% &
public 

AuditTrailAttribute 
( 
string %
	eventName& /
,/ 0
string1 7
description8 C
)C D
{ 
	EventName 
= 
	eventName 
; 
Description 
= 
description !
;! "
} 
} Ý
[d:\BridgeLabz-Training\collections-csharp-practice\scenario-based\event-tracker\EventLog.cs
	namespace 	
EventTrackerApp
 
; 
public 
class 
EventLog 
{ 
public 

required 
string 
Event  
{! "
get# &
;& '
set( +
;+ ,
}- .
public 

required 
string 
Description &
{' (
get) ,
;, -
set. 1
;1 2
}3 4
public 

required 
string 

MethodName %
{& '
get( +
;+ ,
set- 0
;0 1
}2 3
public 

required 
string 
	ClassName $
{% &
get' *
;* +
set, /
;/ 0
}1 2
public		 

DateTime		 
	TimeStamp		 
{		 
get		  #
;		# $
set		% (
;		( )
}		* +
}

 þ
_d:\BridgeLabz-Training\collections-csharp-practice\scenario-based\event-tracker\EventTracker.cs
	namespace 	
EventTrackerApp
 
; 
public 
class 
EventTracker 
{ 
public		 

static		 
void		 
TrackEvents		 "
(		" #
object		# )
obj		* -
)		- .
{

 
Type 
type 
= 
obj 
. 
GetType 
(  
)  !
;! "
foreach 
( 

MethodInfo 
method "
in# %
type& *
.* +

GetMethods+ 5
(5 6
)6 7
)7 8
{ 	
var 
attr 
= 
method 
. 
GetCustomAttribute 0
<0 1
AuditTrailAttribute1 D
>D E
(E F
)F G
;G H
if 
( 
attr 
!= 
null 
) 
{ 
method 
. 
Invoke 
( 
obj !
,! "
null# '
)' (
;( )
EventLog 
log 
= 
new "
EventLog# +
{ 
Event 
= 
attr  
.  !
	EventName! *
,* +
Description 
=  !
attr" &
.& '
Description' 2
,2 3

MethodName 
=  
method! '
.' (
Name( ,
,, -
	ClassName 
= 
type  $
.$ %
Name% )
,) *
	TimeStamp 
= 
DateTime  (
.( )
Now) ,
} 
; 
string 
jsonLog 
=  
JsonSerializer! /
./ 0
	Serialize0 9
(9 :
log: =
,= >
new? B!
JsonSerializerOptionsC X
{ 
WriteIndented   !
=  " #
true  $ (
}!! 
)!! 
;!! 
Console## 
.## 
	WriteLine## !
(##! "
$str##" 0
)##0 1
;##1 2
Console$$ 
.$$ 
	WriteLine$$ !
($$! "
jsonLog$$" )
)$$) *
;$$* +
}%% 
}&& 	
}'' 
}(( ­
Zd:\BridgeLabz-Training\collections-csharp-practice\scenario-based\event-tracker\Program.cs
	namespace 	
EventTrackerApp
 
; 
class 
Program 
{ 
static 

void 
Main 
( 
string 
[ 
] 
args "
)" #
{ 
UserActions 
actions 
= 
new !
UserActions" -
(- .
). /
;/ 0
EventTracker 
. 
TrackEvents  
(  !
actions! (
)( )
;) *
}		 
}

 å

^d:\BridgeLabz-Training\collections-csharp-practice\scenario-based\event-tracker\UserActions.cs
	namespace 	
EventTrackerApp
 
; 
public 
class 
UserActions 
{ 
[ 

AuditTrail 
( 
$str 
, 
$str 6
)6 7
]7 8
public 

void 
Login 
( 
) 
{ 
Console 
. 
	WriteLine 
( 
$str ,
), -
;- .
}		 
[ 

AuditTrail 
( 
$str 
, 
$str 4
)4 5
]5 6
public 

void 

UploadFile 
( 
) 
{ 
Console 
. 
	WriteLine 
( 
$str )
)) *
;* +
} 
[ 

AuditTrail 
( 
$str 
, 
$str 3
)3 4
]4 5
public 

void 

DeleteFile 
( 
) 
{ 
Console 
. 
	WriteLine 
( 
$str (
)( )
;) *
} 
} 