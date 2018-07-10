-- create table in sqlite

create table Post
(
	ID integer NOT NULL PRIMARY KEY autoincrement,
	AuthorID integer,
	PublishTimeStamp text,
	Content text,
	Title text,
	Excerpt text,
	TitleEN text,
	PostStatus integer,
	CommentStatus integer,
	PingStatus integer,
	PostPassword text,
	ShortName text,
	ModifiedTimeStamp text,
	PostParent text,
	Guid text,
	MenuOrder integer,
	PostType integer,
	PostMimeType text,
	CommentCount integer
)

create table Series
(
	ID integer NOT NULL PRIMARY KEY autoincrement,
	PostID integer,
	Author text,
	AuthorEmail text,
	AuthorUrl integer,
	AuthorIP text,
	CommentTimeStamp text,
	Content integer,
	Approved text,
	Type integer,
	Parent integer,
	UserID integer
)